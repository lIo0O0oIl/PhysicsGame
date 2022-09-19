using System.Net.NetworkInformation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DND : MonoBehaviour
{
    private Tleos tleos = null;

    [SerializeField] SpriteRenderer spriteRenderer;
    public Vector3 thisPos;
    float startPosx;
    float startPosY;
    bool isHeld = false;
    public bool isInLine;
    float stickPosY;
    private Vector2 defaultPos = new Vector2();
    private Vector2 factor = new Vector2();
    public Collider2D colp;
    public Collider2D coln;
    public TTleos T = null;

    private void Start()
    {
        thisPos = this.transform.position;
        defaultPos = transform.position;
    }
    private void Awake() {
        tleos = GameObject.Find("GameManager").GetComponent<Tleos>();
    }
    // private void Update()
    // {
    //     if (isHeld)
    //     {
    //         Vector2 mousePos;
    //         mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

    //         this.gameObject.transform.position = new Vector2(mousePos.x - startPosx, mousePos.y - startPosY);
    //     }
    // }

    private void OnMouseDown()
    {
        if(T != null)
        {
            T.d = null;
            T = null;
        }

        spriteRenderer.color = new Color(1f, 1f, 1f, .5f);
        factor = (Vector2)transform.position - (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        isHeld = true;
    }
    private void OnMouseDrag() 
    {
        if(isHeld)
            transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition) + factor;
    }

    private void OnMouseUp()
    {
        spriteRenderer.color = Color.white;
        isHeld = false;

        colp = Physics2D.OverlapCircle(transform.position, 0.5f, 1 << 8);
        coln = Physics2D.OverlapCircle(transform.position, 0.5f, 1 << 9);
        if(colp) Debug.Log(colp.name);
        if(coln) Debug.Log(coln.name);

        if (colp)
        {
            colp.GetComponent<TTleos>().d = this;
            T = colp.GetComponent<TTleos>();
            Debug.Log("P에 " + gameObject.name + " 할당됨");
            gameObject.transform.position = colp.transform.position;
        }
        else if (coln)
        {
            coln.GetComponent<TTleos>().d = this;
            T = coln.GetComponent<TTleos>();
            Debug.Log("N에 " + gameObject.name + " 할당됨");
            gameObject.transform.position = coln.transform.position;
        }
        else
            transform.position = defaultPos;

        TleosManager.Instance.Match();
    }

    private void OnDrawGizmosSelected() {
        Gizmos.color = Color.red;
        Gizmos.DrawCube(transform.position, Vector3.one);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

    }

    // private void OnTriggerExit2D(Collider2D other)
    // {
    //     if (other.CompareTag("stick"))
    //     {
    //         isInLine = false;
    //     }
    // }
}
