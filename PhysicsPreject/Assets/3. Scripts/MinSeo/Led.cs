using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Led : MonoBehaviour
{
    [SerializeField]
    private GameObject led;
    [SerializeField]
    private GameObject pn;

    private SpriteRenderer scolor;

    [SerializeField]
    private float sec = 0.5f;

    private void Awake()
    {
        scolor = led.GetComponent<SpriteRenderer>();

        StartCoroutine(Blink());
        Invoke("FadeIn", 3f);
    }

    private void FadeIn()
    {
        led.transform.DOMove(new Vector3(0, 7, 0), 3f);
        led.transform.DOScale(new Vector3(130, 130, 130), 3f);
        Invoke("Show", 3.5f);
    }

    private void Show()
    {
        led.SetActive(false);
        pn.SetActive(true);
        Invoke("FadeOut",5f);
    }

    private void FadeOut()
    {
        pn.SetActive(false);
        led.SetActive(true);
        led.transform.DOMove(new Vector3(0, 1, 0), 3f);
        led.transform.DOScale(new Vector3(12, 12, 12), 3f);
    }

    IEnumerator Blink()
    {
        while (true)
        {
            scolor.color = Color.red;

            yield return new WaitForSeconds(0.5f);

            scolor.color = Color.white;

            yield return new WaitForSeconds(0.5f);
        }
    }
}