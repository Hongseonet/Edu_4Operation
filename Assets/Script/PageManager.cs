using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

class PageManager : MonoBehaviour
{
    int pageIndex;

    private void OnEnable()
    {

        DelegateEvent.PageEventChange += PageEvent;
    }

    private void OnDisable()
    {

        DelegateEvent.PageEventChange -= PageEvent;
    }


    public void PageEvent(DelegateEventData data)
    {

    }
}