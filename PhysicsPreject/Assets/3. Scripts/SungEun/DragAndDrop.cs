using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DragAndDrop : MonoBehaviour
{
    Tleos tleos = null;

    [SerializeField] SpriteRenderer spriteRenderer;
    public Vector3 thisPos;
    float startPosx;
    float startPosY;
    bool isHeld = false;
    public bool isInLine;
    float stickPosY;
    bool isGo = true;


    public bool nnn = false;


    Move move;

    Camera cam = null;

    private void Start()
    {
        thisPos = this.transform.position;

        move = FindObjectOfType<Move>();
    }

    public void StartN()
    {
        thisPos = this.transform.position;
    }
    private void Update()
    {
        if (isHeld)
        {
            Vector2 mousePos;
            mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

            this.gameObject.transform.position = new Vector2(mousePos.x - startPosx, mousePos.y - startPosY);
        }
    }

    private void OnMouseDown()
    {
        if (isGo)
        {
            if (Input.GetMouseButtonDown(0))
            {
            spriteRenderer.color = new Color(1f, 1f, 1f, .5f);
            Vector3 mousePos;
            mousePos = cam.ScreenToWorldPoint(Input.mousePosition);


                startPosx = mousePos.x - this.transform.position.x;
                startPosY = mousePos.y - this.transform.position.y;

                isHeld = true;

            }
        }
    }

    public void NN(bool a)
    {
        if (a)
        {
            nnn = true;
            thisPos = this.transform.position;
        }
        else
        {
            nnn = false;
            thisPos = this.transform.position;
        }
    }

    private void OnMouseUp()
    {
        spriteRenderer.color = new Color(1f, 1f, 1f, 1f);
        isHeld = false;

        if (isInLine || !isGo)
        {
            this.gameObject.transform.position = new Vector3(gameObject.transform.position.x, stickPosY, 0);

            if (nnn)
            {
                transform.DOMoveX(4.5f, 2f).SetEase(Ease.Linear);
            }
            else
            {
                transform.DOMoveX(10f, 2f).SetEase(Ease.Linear);
            }
            Invoke("Del", 2f);
        }
        else
            this.gameObject.transform.position = thisPos;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("stick"))
        {
            isInLine = true;
            isGo = false;
            stickPosY = other.transform.position.y;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("stick"))
        {
            isInLine = false;
            isGo = true;
        }
    }

    void Del()
    {
        //Destroy(gameObject);
        move.gogo++;
        gameObject.SetActive(false);
    }

    public void PB()
    {
        gameObject.GetComponent<SpriteRenderer>().DOFade(0f, 1.5f);
        gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0);
        gameObject.SetActive(true);
        gameObject.transform.position = thisPos;
    }
}