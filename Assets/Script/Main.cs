using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    [SerializeField]
    bool isDev;

    [SerializeField]
    Transform canvasRoot, pageRoot;

    int pageIndex;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        CONST_VALUE.Instance.ISDEV = isDev;
        
        Common.Instance.SetLocalization(0);

        pageRoot.GetChild(0).gameObject.SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        } 
    }

    private void OnEnable()
    {

        DelegateEvent.PageEventChange += PageEvent;
    }

    private void OnDisable()
    {

        DelegateEvent.PageEventChange -= PageEvent;
    }


    //delegate button event
    public void PageEvent(DelegateEventData data)
    {
        Common.Instance.Log("PageEvent", data.btnTarget);

        switch (data.btnTarget.name.Split('_')[1].ToLower())
        {
            case "operations":

                break;
        }
        
    }
}