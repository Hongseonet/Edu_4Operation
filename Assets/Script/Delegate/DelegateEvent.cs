using System;
using UnityEngine;

public class DelegateEvent : MonoBehaviour
{
    public static event Action<DelegateEventData> PageEventChange;
    static DelegateEventData pageEventChange;


    public static DelegateEventData PageEvent
    {
        get { return pageEventChange; }
        set
        {
            pageEventChange = value;

            if (PageEventChange != null)
                PageEventChange.Invoke(pageEventChange);
        }
    }
}