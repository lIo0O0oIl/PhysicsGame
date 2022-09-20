using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tleoswlswk : MonoBehaviour
{
    public static Tleoswlswk instance;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(instance.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);

    }
}