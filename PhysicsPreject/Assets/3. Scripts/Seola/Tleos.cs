using DG.Tweening;
using UnityEngine;

public class Tleos : MonoBehaviour
{
    private Rigidbody2D rb2dJ = null;
    private Rigidbody2D rb2dY = null;
    [SerializeField] private float speed = 0f;

    [SerializeField] private GameObject junja = null;
    [SerializeField] private GameObject yagrog = null;
    private void Awake() {
        rb2dJ = GameObject.Find("P-N/N/Njun").GetComponent<Rigidbody2D>();
        rb2dY = GameObject.Find("P-N/P/PYag").GetComponent<Rigidbody2D>();
    }
    private void Update() {
        float dmdkr = Time.deltaTime;
    }
    public void SunVector() {
        Debug.Log("1");
        
        junja.transform.DOLocalMoveX(-2.2f, 1f).SetEase(Ease.Linear);
    }
    public void durVector() {
        Debug.Log("2");
        junja.transform.DOLocalMoveX(0.5f, 1f).SetEase(Ease.Linear);
        yagrog.transform.DOLocalMoveX(-0.5f, 1f).SetEase(Ease.Linear);
        }
    }
    // public void durVector() {
        
    // }
