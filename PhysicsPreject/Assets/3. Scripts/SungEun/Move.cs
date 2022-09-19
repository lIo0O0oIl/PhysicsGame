using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Move : MonoBehaviour
{
    [SerializeField] GameObject p_S, n_S, p_1, n_1;

    [SerializeField]
    SpriteRenderer[] oO;

    SpriteRenderer[] p_1A;


    // Start is called before the first frame update
    void Start()
    {
        p_S.transform.DOMove(new Vector3(-16.8f, 20.8f, 0), 3f);
        p_S.transform.DOScale(new Vector3(210, 210, 0), 3f);

        Invoke("SetA", 2f);
    }

    void SetA()
    {
        p_1.SetActive(true);
        p_1A = p_1.GetComponentsInChildren<SpriteRenderer>();

        for (int i = 0; i < p_1A.Length; i++)
        {
            p_1A[i].DOFade(1f, 1f);
        }

        Invoke("SetA_A", 1f);
    }

    void SetA_A()
    {
        for (int i = 0; i < oO.Length; i++)
        {
            oO[i].DOFade(1f, 1f);
        }
    }
}
