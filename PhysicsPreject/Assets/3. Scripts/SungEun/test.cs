using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float moveSpeed;
    public float xMin, xMax, yMin, yMax;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            transform.position -=
                new Vector3(Input.GetAxis("Mouse X") * moveSpeed * Time.deltaTime, 0f,
                Input.GetAxis("Mouse Y") * moveSpeed * Time.deltaTime);
        }

        float x = Mathf.Clamp(transform.position.x, xMin, yMax);
        float z = Mathf.Clamp(transform.position.z, yMin, yMax);

        transform.position = new Vector3(x, transform.position.y, z);
    }
}
