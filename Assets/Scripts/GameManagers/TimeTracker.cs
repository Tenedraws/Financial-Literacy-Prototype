using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeTracker : Singleton<TimeTracker>
{
    float timer;
    //1 minute is 1 hour
    float timeBetweenHours = 5; 

    //starts at 7am
    public int hour = 7;
    bool midnight = false;

    private void Start()
    {
        timer = 0; 
    }
    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime; 
        if(timer <= 0)
        {
            timer = timeBetweenHours;
            hour++;
            MainUIElements.Instance.hour.text = $"Time: \n {hour}:00";
            if (hour == 24 & !midnight)
            {
                midnight = true;
                UIManager.Instance.Open(GameUIID.EndScreen);
                Endscreen.Instance.endText.text = "YOU DID IT! \n You managed to make it through a day with your Buddy! Good job!";
            }
        }
    }
}
