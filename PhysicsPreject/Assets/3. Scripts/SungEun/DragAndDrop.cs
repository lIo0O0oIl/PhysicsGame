using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
    // IBeginDragHendler�� �巡�׸� ������ �� ȣ���. IEndDragHandler�� ���콺Ŭ���� ���� ȣ���̵�, IDragHandler�� �巡�� �ϰ� ���� �� ����ؼ� ȣ���.
{
    //public static Vector2 defaultPos;

    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {
        //defaultPos = this.transform.position;
    }

    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        //Vector2 currentPos = eventData.position;
        //this.transform.position = currentPos;

        transform.position = eventData.position;
    }

    void IEndDragHandler.OnEndDrag(PointerEventData eventData)
    {
        //Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //this.transform.position = defaultPos;
    }
}
