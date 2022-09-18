using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    [SerializeField] SpriteRenderer spriteRenderer;
    public Vector3 thisPos;
    float startPosx;
    float startPosY;
    bool isHeld = false;
    public bool isInLine;
    float stickPosY;
    float stickPosX;

    private void Start()
    {
        thisPos = this.transform.position;
    }
    private void Update()
    {
        if (isHeld)
        {
            Vector2 mousePos;
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            this.gameObject.transform.position = new Vector2(mousePos.x - startPosx, mousePos.y - startPosY);
        }
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {

            spriteRenderer.color = new Color(1f, 1f, 1f, 0.5f);
            Vector3 mousePos;
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);


            startPosx = mousePos.x - this.transform.position.x;
            startPosY = mousePos.y - this.transform.position.y;


            isHeld = true;

        }
    }

    private void OnMouseUp()
    {
        spriteRenderer.color = new Color(1f, 1f, 1f, 1f);
        isHeld = false;

        if (isInLine)
            this.gameObject.transform.position = new Vector3(stickPosX, stickPosY, 0);
        else
            this.gameObject.transform.position = thisPos;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("stick"))
        {
            isInLine = true;
            stickPosY = other.transform.position.y;
            stickPosX = other.transform.position.x;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("stick"))
        {
            isInLine = false;
        }
    }
}
