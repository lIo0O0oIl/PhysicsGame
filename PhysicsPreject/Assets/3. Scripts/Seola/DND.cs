// using System.Net;
// using System.Transactions;
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.EventSystems;

// public class DND : MonoBehaviour, IPointerDownHandler, IDragHandler
// {
//     [SerializeField] private Transfrom mousePos;
//     private Vector3 
// }
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DND : MonoBehaviour, /*IBeginDragHandler,*/ IEndDragHandler, IDragHandler
{
    public static Vector2 pos;
    public Image redPos;
    public Image bluePos;

    // void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    // {
    //     pos = this.transform.position;
    // }

    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        Vector2 currentPos = eventData.position;
        this.transform.position = currentPos;
    }

    void IEndDragHandler.OnEndDrag(PointerEventData eventData)
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        this.transform.position = pos;
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (CompareTag("+") && other.CompareTag("P")) {
            if (CompareTag("-") && other.CompareTag("N")) {
                Debug.Log("1");
                pos = redPos.transform.position;
                //순방향 이동 호출
            }
        }
        else if (CompareTag("+") && other.CompareTag("N")) {
            if (CompareTag("-") && other.CompareTag("P")) {
                Debug.Log("2");
                pos = redPos.transform.position;
                //역방향 이동 호출
            }
        }
        else {Debug.Log("제대로 연결해주세요");}
    }
}