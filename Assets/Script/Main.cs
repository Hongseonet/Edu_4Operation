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


    public void PageEvent(DelegateEventData data)
    {
        Common.Instance.Log("PageEvent", data.operations);
    }

    public void BtnEvent(Button btn)
    {

    }
}