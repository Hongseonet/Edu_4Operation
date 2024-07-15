using UnityEngine;
using UnityEngine.EventSystems;

public class Card : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IPointerDownHandler, IPointerUpHandler, IDragHandler
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

    public void OnEndDrag(PointerEventData eventData)
    {
        Common.Instance.Log("OnEndDrag", "ee");
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Common.Instance.Log("OnBeginDrag", "dd");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Common.Instance.Log("OnPointerUp", "dd");
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Common.Instance.Log("OnPointerDown", "OnPointerDown");
    }

    public void OnDrag(PointerEventData eventData)
    {
        Common.Instance.Log("OnDrag", "OnDrag");
    }
}