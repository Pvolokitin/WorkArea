using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float rIntensity = 5.0f;
    [SerializeField] float mIntensity = 3.0f;

    Vector3 delta;

    void Start()
    {
        delta = transform.position - target.position;

        transform.LookAt(target);
    }

    
    void Update()
    {
        float x = Input.GetAxis("Mouse X") * rIntensity;
        float y = Input.GetAxis("Mouse Y") * mIntensity;

        if (Input.GetMouseButton(1))    // Hold Right click mouse get grab camera rotation around target
        {
            delta = Quaternion.AngleAxis(x, Vector3.up) * delta;        // up - down
            delta = Quaternion.AngleAxis(y, -transform.right) * delta;  // left - right
        }

        
        // camera scroll

            //float scroll = Input.mouseScrollDelta.y;
            //Debug.Log(delta);

            //if (scroll != 0.0f)
            //{
            //    var newDelta = delta - delta.normalized * scroll * mIntensity;

            //    if (newDelta.sqrMagnitude > 1.0f)
            //    {
            //        delta = newDelta;
            //    }
            //}       
        

        transform.position = target.position + delta;

        transform.LookAt(target);
    }

}
