using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
    // IBeginDragHendler�� �巡�׸� ������ �� ȣ���. IEndDragHandler�� ���콺Ŭ���� ���� ȣ���̵�, IDragHandler�� �巡�� �ϰ� ���� �� ����ؼ� ȣ���.
{
    //public static Vector2 defaultPos;
    public float xMin, yMin, xMax, yMax;

    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {
        //defaultPos = this.transform.position;
    }

    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        //Vector2 currentPos = eventData.position;
        //this.transform.position = currentPos;

        if (transform.position = new Vector3(1, 4, 5))

        
        transform.position = eventData.position;
        //transform.position = new Vector3(Mathf.Clamp(transform.position.x, xMin, xMax), Mathf.Clamp(transform.position.y, yMin, yMax), 0);

    }

    void IEndDragHandler.OnEndDrag(PointerEventData eventData)
    {
        //Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //this.transform.position = defaultPos;
    }

    private void Update()
    {
        //transform.position = new Vector3(Mathf.Clamp(transform.position.x, xMin, xMax), Mathf.Clamp(transform.position.y, yMin, yMax), 0);
    }
}
