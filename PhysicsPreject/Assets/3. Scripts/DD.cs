using DG.Tweening;
using UnityEngine;

public class DD : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            transform.DOMove(Vector3.left, 3f);
        }
    }
}
