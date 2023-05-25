using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventManager : MonoBehaviour
{
    [SerializeField]
    EventData eventData;
    TimeTracker timeTracker;
    int eventIndex;

    private void Start()
    {
        timeTracker = TimeTracker.Instance;
    }
    private void Update()
    {
        if(eventIndex >= eventData.events.Count)
        {
            return;
        }
        if(timeTracker.hour >= eventData.events[eventIndex].time)
        {
            Debug.Log(eventData.events[eventIndex].msg);
            UIManager.Instance.Open(GameUIID.Choices);
            Time.timeScale = 0f; 
            ChoicesElements.Instance.initializeButtons(eventData.events[eventIndex].buttonBehaviors);
            ChoicesElements.Instance.scenario.text = eventData.events[eventIndex].eventDescription;
            eventIndex += 1; 
        }
    }
}
