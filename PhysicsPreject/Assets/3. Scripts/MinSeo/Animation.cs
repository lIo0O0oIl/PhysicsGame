using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    [SerializeField]
    private GameObject First;
    [SerializeField]
    private Animation animPlay_P;
    [SerializeField]
    private Animation animPlay_N;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        First.SetActive(false); 
    }
}
