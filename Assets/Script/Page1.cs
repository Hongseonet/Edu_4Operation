using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.UI;

class Page1 : PageManager
{
    [SerializeField]
    Transform buttonRoot, textRoot;


    private void OnEnable()
    {
        foreach(Transform item in buttonRoot)
        {
            if (item.GetComponent<Button>() == null)
                return;

            Button btn = item.GetComponent<Button>();
            btn.onClick.AddListener(() => BtnEvent(btn));
        }

        SetText();
    }

    void SetText()
    {
        Common.Instance.Log("dd", Common.Instance.GetLocalizedString("localize", "appName"));
    }

    private void OnDisable()
    {
        foreach (Transform item in buttonRoot)
        {
            Button btn = item.GetComponent<Button>();
            btn.onClick.RemoveAllListeners();
        }

    }

    void BtnEvent(Button btn)
    {
        PageEvent = new DelegateEventData
        {
            btnTarget = btn.gameObject,
        };
    }
}