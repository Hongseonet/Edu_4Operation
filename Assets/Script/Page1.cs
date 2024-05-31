using UnityEditor.Localization.Plugins.XLIFF.V12;
using UnityEngine;
using UnityEngine.UI;

class Page1 : PageManager
{
    [SerializeField]
    Transform buttonRoot;


    private void OnEnable()
    {
        foreach(Transform item in buttonRoot)
        {
            if (item.GetComponent<Button>() == null)
                return;

            Button btn = item.GetComponent<Button>();
            btn.onClick.AddListener(() => BtnEvent(btn));
        }
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