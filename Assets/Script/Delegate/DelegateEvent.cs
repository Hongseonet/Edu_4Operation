using System;
using UnityEngine;

public class DelegateEvent : MonoBehaviour
{
    public static event Action<DelegateEventData> PageEventChange;
    static DelegateEventData pageEventChange;

    protected AudioClip audioClip;
    protected bool isButtonDisable;


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

    protected void TabSound(string audio)
    {
        try
        {
            audioClip = Common.Instance.GetAudioClip(true, audio);
            GetComponentInParent<AudioSource>().PlayOneShot(audioClip);
        }catch(Exception ex)
        {

        }
    }
}