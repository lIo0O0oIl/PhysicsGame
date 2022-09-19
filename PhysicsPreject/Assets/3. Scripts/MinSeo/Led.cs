using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Led : MonoBehaviour
{
    [SerializeField]
    private GameObject led;

    SpriteRenderer[] ledF;
    
    private void Start()
    {
        Invoke("FadeIn", 1f);
    }

    private void FadeIn()
    {
        led.transform.DOMove(new Vector3(0, 7, 0), 3f);
        led.transform.DOScale(new Vector3(130, 130, 130), 3f);
        Invoke("FadeOut", 1f);
    }

    private void FadeOut()
    {
        led.SetActive(true);
        led.transform.DOMove(new Vector3(0, 1, 0), 3f);
        led.transform.DOScale(new Vector3(12, 12, 12), 3f);
    }
}
