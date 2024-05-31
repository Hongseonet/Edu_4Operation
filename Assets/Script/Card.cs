using UnityEngine;

public class Card : MonoBehaviour
{
    private void OnEnable()
    {
        
    }

    private void OnDestroy()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Common.Instance.Log("coll ent", collision.transform.name);
    }

    private void OnCollisionStay(Collision collision)
    {
        Common.Instance.Log("coll in", collision.transform.name);
    }

    private void OnCollisionExit(Collision collision)
    {
        Common.Instance.Log("coll ext", collision.transform.name);
    }
}