using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using TMPro;

public class Move : MonoBehaviour
{
    [SerializeField] GameObject p_S, n_S, p_1, n_1;

    [SerializeField]
    SpriteRenderer[] oO;

    [SerializeField] GameObject title, P, N;

    [SerializeField] GameObject p_B, n_B;

    SpriteRenderer[] p_1A, n_1A;


    // Start is called before the first frame update
    void Start()
    {
        title.GetComponent<TextMeshProUGUI>().DOFade(1f, 2f);
        Invoke("Setting", 2.5f);
    }

    void Setting()
    {
        title.GetComponent<TextMeshProUGUI>().DOFade(0f, 2f);
        Invoke("Setting_2", 1.5f);
    }

    void Setting_2()
    {
        p_S.SetActive(true);
        n_S.SetActive(true);
        P.SetActive(true);
        N.SetActive(true);
        p_B.SetActive(true);
        n_B.SetActive(true);

        p_S.GetComponent<SpriteRenderer>().DOFade(1f, 1.5f); ;
        n_S.GetComponent<SpriteRenderer>().DOFade(1f, 1.5f);
        P.GetComponent<TextMeshProUGUI>().DOFade(1f, 1.5f);
        N.GetComponent<TextMeshProUGUI>().DOFade(1f, 1.5f);
    }

    public void P_S()
    {
        n_S.SetActive(false);
        P.SetActive(false);
        N.SetActive(false);
        p_B.SetActive(false);
        n_B.SetActive(false);


        p_S.transform.DOMove(new Vector3(-16.8f, 20.8f, 0),3f).SetEase(Ease.InQuad);
        p_S.transform.DOScale(new Vector3(210, 210, 0), 3f).SetEase(Ease.InQuad);

        Invoke("SetA", 3.2f);
    }

    void SetA()
    {
        p_1.SetActive(true);
        p_1A = p_1.GetComponentsInChildren<SpriteRenderer>();

        for (int i = 0; i < p_1A.Length; i++)
        {
            p_1A[i].DOFade(1f, 1.5f);
        }

        Invoke("SetA_A", 1.2f);
    }

    void SetA_A()
    {
        for (int i = 0; i < oO.Length; i++)
        {
            oO[i].DOFade(1f, 1.5f);
        }
    }

    public void N_S()
    {
        p_S.SetActive(false);
        P.SetActive(false);
        N.SetActive(false);
        p_B.SetActive(false);
        n_B.SetActive(false);

        n_S.transform.DOMove(new Vector3(19f, -43.5f, 0), 3f).SetEase(Ease.InQuad);
        n_S.transform.DOScale(new Vector3(235, 235, 0), 3f).SetEase(Ease.InQuad);
        Camera.main.DOOrthoSize(2f, 3f);

        Invoke("SetB", 3.1f);
    }

    void SetB()
    {
        n_1.SetActive(true);
        n_1A = n_1.GetComponentsInChildren<SpriteRenderer>();

        for (int i = 0; i < n_1A.Length; i++)
        {
            n_1A[i].DOFade(1f, 1.5f);
        }
    }
}
