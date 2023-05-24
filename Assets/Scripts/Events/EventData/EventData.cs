using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; 

[CreateAssetMenu]
public class EventData : ScriptableObject
{
    public List<Event> events; 
}

[Serializable]
public class Event
{
    public float time;
    public string msg;
    [TextArea]
    public string eventDescription; 
    public List<ButtonBehavior> buttonBehaviors;
}
