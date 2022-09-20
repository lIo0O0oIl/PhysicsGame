using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class Tleos : MonoBehaviour
{
    private Rigidbody2D rb2dJ = null;
    private Rigidbody2D rb2dY = null;
    [SerializeField] private float speed = 0f;

    [SerializeField] public GameObject junja = null;
    [SerializeField] private GameObject yagrog = null;

    [SerializeField] private Image dmdkr = null;

    [SerializeField] private DND dndp = null;
    [SerializeField] private DND dndn = null;
    public Vector2 junjaDir = Vector2.zero;

    private void Awake() {
        rb2dJ = GameObject.Find("P-N/N/Njun").GetComponent<Rigidbody2D>();
        rb2dY = GameObject.Find("P-N/P/PYag").GetComponent<Rigidbody2D>();
        junjaDir = junja.transform.position;
        // dmdkr = GameObject.Find("Canvas/dmdkr").GetComponent<Image>();
        // dnd = GameObject.Find("+-/+").GetComponent<DND>();
    }
    private void Update() {
        float dmdkr = Time.deltaTime;
    }
    public void rere() {
        Debug.Log("1");
        dndp.dmddo();
        dndn.dmddo();
    }
    public void SunVector() {
        junja.transform.DOLocalMoveX(-2.2f, 1f).SetEase(Ease.Linear);
        dmdkr.gameObject.SetActive(true);
        Invoke("rere", 5f);
    }
    public void durVector() {
        Debug.Log("qwerty");
        dmdkr.gameObject.SetActive(false);
        junja.transform.DOLocalMoveX(0.5f, 1f).SetEase(Ease.Linear);
        yagrog.transform.DOLocalMoveX(-0.5f, 1f).SetEase(Ease.Linear);
        Invoke("rere", 5f);
        }
    }
    // public void durVector() {
        
    // }
