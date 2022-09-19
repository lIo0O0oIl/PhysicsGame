using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btn : MonoBehaviour
{
    [SerializeField]
    private GameObject first;
    [SerializeField]
    private GameObject p_Semiconductor;
    [SerializeField]
    private GameObject n_Semiconductor;

    public void ClickP()
    {
        first.SetActive(false);
        p_Semiconductor.SetActive(true);
    }

    public void ClickN()
    {
        first.SetActive(false);
        n_Semiconductor.SetActive(true);
    }
}
