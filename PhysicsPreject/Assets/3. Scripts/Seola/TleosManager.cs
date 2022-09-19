using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TleosManager : MonoBehaviour
{
    public static TleosManager Instance = null;
    public TTleos TTLeft = null;
    public TTleos TTRight = null;
    private Tleos tleos= null;

    private void Awake() {
        tleos = GameObject.Find("GameManager").GetComponent<Tleos>();

        if(Instance == null)
            Instance = this;
    }

    public void Match()
    {
        if(TTLeft.d != null && TTRight.d != null)
        {
            switch(TTLeft.d.name + TTRight.d.name)
            {
                case "+-":
                    Debug.Log("+-");
                    tleos.SunVector();
                    break;
                case "-+":  
                    Debug.Log("-+");
                    tleos.durVector();
                    break;
            }
        }
    }
}
