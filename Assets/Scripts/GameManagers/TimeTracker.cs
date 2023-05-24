using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeTracker : Singleton<TimeTracker>
{
    public float timer;

    private void Start()
    {
        timer = 0; 
    }
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; 
    }
}
