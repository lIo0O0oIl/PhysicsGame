using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Led : MonoBehaviour
{
    [SerializeField]
    private GameObject led;

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
        Invoke("FadeOut", 2f);
        led.SetActive(false);
    }

    private void FadeOut()
    {
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
