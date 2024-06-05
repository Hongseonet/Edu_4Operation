using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization;
using TMPro;

public class Main : MonoBehaviour
{
    [SerializeField]
    bool isDev;

    [SerializeField]
    Transform canvasRoot, pageRoot;

    [SerializeField]
    TextMeshProUGUI textTitle;

    int pageIndex;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        CONST_VALUE.Instance.ISDEV = isDev;


        Locale currentSelectedLocale = LocalizationSettings.SelectedLocale;
        ILocalesProvider availableLocales = LocalizationSettings.AvailableLocales;

        if (currentSelectedLocale == availableLocales.GetLocale("fr"))
        {

        }

        Common.Instance.SetLocalization(1); //0 eng, 1 kor

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
        Common.Instance.Log("PageEvent", data.objTarget);
        string[] splitName = data.objTarget.name.Split('_');
    }
}