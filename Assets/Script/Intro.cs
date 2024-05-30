using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class Intro : MonoBehaviour
{
    [SerializeField]
    bool isDev;

    [SerializeField]
    Transform cardRoot;

    [SerializeField]
    Image imgRoot;
    

    
    void Awake()
    {
        CONST_VALUE.Instance.ISDEV = isDev;

        Common.Instance.SetImage(true, "UI/BG_" + Random.Range(0,2), imgRoot);

        StartCoroutine(CardRandomArrange());
    }

    IEnumerator CardRandomArrange()
    {
        List<int> randomIndex = new List<int>();


        for(int i=0; i< cardRoot.childCount; i++)
        {
            int rand = Random.Range(0, 10);

            yield return null;

            if (randomIndex.Contains(rand))
            {
                i--;
                continue;
            }
            else
            {
                randomIndex.Add(rand);
            }
        }


        for(int i=0; i<cardRoot.childCount; i++)
        {
            Common.Instance.SetImage(true, "UI/card_" + randomIndex[i], cardRoot.GetChild(i).GetComponent<Image>());
        }

        yield return new WaitForSecondsRealtime(2f);
        SceneManager.LoadSceneAsync("Main");
    }

    IEnumerator CaedFadeOn()
    {
        while (true)
        {
            yield return new WaitForSecondsRealtime(5f);
        }
    }
}