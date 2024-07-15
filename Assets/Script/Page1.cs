using TMPro;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.UI;

class Page1 : PageManager
{
    [SerializeField]
    Transform textRoot;


    private void OnEnable()
    {
        foreach(Transform item in buttonRoot)
        {
            if (item.GetComponent<Button>() == null)
                return;

            Button btn = item.GetComponent<Button>();
            btn.onClick.AddListener(() => ButtonEvent(btn));
        }

        SetText();
    }

    void SetText()
    {
        Common.Instance.Log("dd", Common.Instance.GetLocalizedString("localize", "appName"));

        string[] arrString = new string[] { "addiction", "subtraction", "multiplication", "division" };

        for(int i = 0; i < textRoot.childCount; i++)
        {
            textRoot.GetChild(i).GetComponent<TextMeshProUGUI>().text = Common.Instance.GetLocalizedString("localize", arrString[i]);
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

    public void ButtonEvent(Button button)
    {
        string[] splitName = button.name.Split('_');

        if (splitName[1].ToLower().Equals("operations"))
        {
            switch (splitName[2])
            {
                case "1":
                    operation = "addiction";
                    break;
                case "2":
                    operation = "subtraction";
                    break;
                case "3":
                    operation = "multiplication";
                    break;
                case "4":
                    operation = "division";
                    break;
            }
        }

        this.gameObject.SetActive(false);
        pageIndex++;
        //pageRoot.GetChild(pageIndex).gameObject.SetActive(true);

    }
}