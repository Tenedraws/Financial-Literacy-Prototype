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

    [SerializeField]
    List<ButtonSetter> buttonSetter;

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
        if(timeTracker.timer > eventData.events[eventIndex].time)
        {
            Debug.Log(eventData.events[eventIndex].msg);
            initializeButtons(eventData.events[eventIndex].buttonBehaviors);
            eventIndex += 1; 
        }
    }

    public void initializeButtons(List<ButtonBehavior> buttonBehaviors)
    {
        for(int i = 0; i < buttonBehaviors.Count; i++)
        {
            buttonSetter[i].gameObject.SetActive(true);
            buttonSetter[i].Clean();
            buttonSetter[i].buttonBehavior = buttonBehaviors[i];
            buttonSetter[i].Set(buttonBehaviors[i]);
        }
    }
}
