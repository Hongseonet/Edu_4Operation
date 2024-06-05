using UnityEngine;
using UnityEngine.UI;

class Page2 : PageManager
{
    [SerializeField]
    Transform cardRoot;


    private void OnEnable()
    {


        return;

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
        return;

        foreach (Transform item in buttonRoot)
        {
            Button btn = item.GetComponent<Button>();
            btn.onClick.RemoveAllListeners();
        }

    }

    void BtnEvent(Button btn)
    {
        int chooseOperation = int.Parse(btn.name.Split('_')[2]);

        PageEvent = new DelegateEventData
        {
            //operations = chooseOperation,
        };
    }
}