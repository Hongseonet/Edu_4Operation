using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class Intro : MonoBehaviour
{
    [SerializeField]
    Transform cardRoot;

    [SerializeField]
    Image imgRoot;
    

    
    void Start()
    {
        int imageIndex = Random.Range(0, 2);
        if(imageIndex % 2 == 0)
        {

        }
        else
        {

        }


        StartCoroutine(NextScene());
    }

    void CardRandomArrange()
    {
        List<int> randomIndex = new List<int>();


        for(int i=0; i< cardRoot.childCount; i++)
        {
            int rand = (int)Random.Range(0, 10);
            randomIndex.Add(rand);

            if (randomIndex.Contains(rand))
            {

            }
        }
    }

    IEnumerator CaedFadeOn()
    {
        while (true)
        {
            yield return new WaitForSecondsRealtime(5f);
        }
        
    }

    IEnumerator NextScene()
    {
        yield return new WaitForSecondsRealtime(5f);

        SceneManager.LoadSceneAsync("Main");
    }
}