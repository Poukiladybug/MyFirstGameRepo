using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstCOmponent : MonoBehaviour
{
    public float rotationSpeed;

    public bool reverse;

    public Vector3 rotationAxes;

    void Start()
    {
        Debug.Log("Coucou start fonction");
    }

    void Update()
    {
        

        if(reverse)
        {
            transform.Rotate(-rotationAxes * rotationSpeed * Time.deltaTime, Space.World);
        }
        else
        {
            transform.Rotate(rotationAxes * rotationSpeed *Time.deltaTime, Space.World);
        }
    }
}
