using System.Xml.Serialization;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Btn : MonoBehaviour
{
    [SerializeField]
    private GameObject first;
    [SerializeField]
    private GameObject p_Semiconductor;
    [SerializeField]
    private GameObject n_Semiconductor;
    [SerializeField] private Canvas can = null;

    public void ClickP()
    {
        first.SetActive(false);
        p_Semiconductor.SetActive(true);
        can.gameObject.SetActive(false);
    }

    public void ClickN()
    {
        first.SetActive(false);
        n_Semiconductor.SetActive(true);
    }
}
