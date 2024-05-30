using UnityEngine;

public class Main : MonoBehaviour
{
    [SerializeField]
    Transform canvasRoot, pageRoot;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
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
}