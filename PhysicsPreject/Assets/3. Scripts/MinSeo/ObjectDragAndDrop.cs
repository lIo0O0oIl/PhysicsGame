using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDragAndDrop : MonoBehaviour
{
    [SerializeField] 
    SpriteRenderer sprite;

    public Vector3 LoadedPos;
    float startPosx;
    float startPosY;
    bool isBeingHeld = false;
    public bool isLine;
    float timelinePosY;

    private void Start()
    {
        LoadedPos = this.transform.position;
    }

    private void Update()
    {
        if(isBeingHeld)
        {
            Vector2 mousePos;
            mousePos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
            Debug.LogError(".");
            this.gameObject.transform.position = new Vector2(mousePos.x - startPosx, mousePos.y - startPosY);

        }
    }

    private void OnMouseDown()
    {
        if(Input.GetMouseButton(0))
        {
            Vector3 mousePos;
            mousePos = Camera.main.ScreenToViewportPoint(Input.mousePosition);

            startPosx = mousePos.x - this.transform.position.x;
            startPosY = mousePos.y - this.transform.position.y;

            isBeingHeld = true;
        }
    }

    private void OnMouseUp()
    {
        isBeingHeld = false;

        if (isLine)
            this.gameObject.transform.position = new Vector3(this.gameObject.transform.localPosition.x, timelinePosY, -1f);
        else
            this.gameObject.transform.position = LoadedPos;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Line"))
        {
            isLine = true;
            timelinePosY = other.transform.position.y;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Line"))
        {
            isLine = false;
        }
    }
}
