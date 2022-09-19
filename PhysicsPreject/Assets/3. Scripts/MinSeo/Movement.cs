using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private GameObject first;

    [SerializeField]
    private GameObject molecule;
    [SerializeField]
    private GameObject Square;
    [SerializeField]
    private GameObject Square1;

    private void Start()
    {
        Invoke("Move", 0.5f);
        Invoke("Indicate", 4f);
    }

    private void Move()
    {
        molecule.transform.DOMove(new Vector3(0, 0, 0), 3f);
    }

    private void Indicate()
    {
        Invoke("Exit", 2f);
        Square.SetActive(false);
        molecule.SetActive(false);
        Square1.SetActive(true);
    }

    private void Exit()
    {
        Square1.SetActive(false);
        first.SetActive(true);
    }
}
