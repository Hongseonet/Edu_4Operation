using System;
using UnityEngine;
using UnityEngine.UI;

public class Common : SingletonManager<Common>
{
    public GameObject NewObject(string prefabPath, Transform transform)
    {
        GameObject obj = UnityEngine.Object.Instantiate(Resources.Load(prefabPath), transform) as GameObject;
        return obj;
    }

    public GameObject NewObject(GameObject targetObject, Transform transform)
    {
        GameObject obj = UnityEngine.Object.Instantiate(targetObject, transform);
        return obj;
    }

    public GameObject NewObject(Transform targetObject, Transform transform)
    {
        GameObject obj = UnityEngine.Object.Instantiate(targetObject.gameObject, transform);
        return obj;
    }

    public void Log(string msg1, object msg2, string color = "#ffffff")
    {
        if(CONST_VALUE.Instance.ISDEV)
            Debug.Log("<color=" + color + ">" + msg1 + " / " + msg2 + "</color>");
    }

    public void SetImage(bool isLocal, string resourcePath, Image image)
    {
        if (isLocal)
            image.sprite = Resources.Load<Sprite>(resourcePath);
        else
        {

        }
    }

    public void SetImage(bool isLocal, string resourcePath, Button button)
    {
        if (isLocal)
            button.GetComponent<Image>().sprite = Resources.Load<Sprite>(resourcePath);
        else
        {

        }
    }
    public void SetImage(bool isLocal, string resourcePath, GameObject gameObject)
    {
        if (isLocal)
        {
            if(gameObject.GetComponent<Image>() != null)
                gameObject.GetComponent<Image>().sprite = Resources.Load<Sprite>(resourcePath);
        }
        else
        {

        }
    }

    public void SetImageColor(string colorCode, Image image)
    {
        Vector4 convertColor;
        if (colorCode.Length == 7) //#ffffff
            convertColor = new Vector4(Convert.ToInt32(colorCode.Substring(1, 2), 16), Convert.ToInt32(colorCode.Substring(3, 2), 16), Convert.ToInt32(colorCode.Substring(5, 2), 16), 255);
        else
            convertColor = new Vector4(Convert.ToInt32(colorCode.Substring(1, 2), 16), Convert.ToInt32(colorCode.Substring(3, 2), 16), Convert.ToInt32(colorCode.Substring(5, 2), 16), Convert.ToInt32(colorCode.Substring(7, 2), 16));

        image.color = new Color(convertColor.x / 256f, convertColor.y / 256f, convertColor.z / 256f, convertColor.w / 256f);
    }

    public void SetImageColor(string colorCode, GameObject gameObject)
    {
        Vector4 convertColor;
        if (colorCode.Length == 7) //#ffffff
            convertColor = new Vector4(Convert.ToInt32(colorCode.Substring(1, 2), 16), Convert.ToInt32(colorCode.Substring(3, 2), 16), Convert.ToInt32(colorCode.Substring(5, 2), 16), 255);
        else
            convertColor = new Vector4(Convert.ToInt32(colorCode.Substring(1, 2), 16), Convert.ToInt32(colorCode.Substring(3, 2), 16), Convert.ToInt32(colorCode.Substring(5, 2), 16), Convert.ToInt32(colorCode.Substring(7, 2), 16));

        if (gameObject.GetComponent<Image>() != null)
            gameObject.GetComponent<Image>().color = new Color(convertColor.x, convertColor.y, convertColor.z, convertColor.w);
    }

    public AudioClip GetAudioClip(bool isLocal, string audioPath)
    {
        AudioClip audioClip = null;

        if (isLocal)
            audioClip = Resources.Load<AudioClip>("Sounds/" + audioPath);

        return audioClip;
    }

    public void AB()
    {
        
    }

    public int GetLCM(int a, int b)
    {
        return (a * b) / GetGCD(a, b);
    }


    public int GetGCD(int a, int b)
    {
        return b == 0 ? a : GetGCD(b, a % b);
    }
}