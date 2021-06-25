using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCounter : MonoBehaviour
{

    public ObjectMovement movementComponent;
    // Start is called before the first frame update
    void Start()
    {
        //col = GetComponent<Collider>();
        movementComponent = GetComponent <ObjectMovement>();
        Debug.Log($"Nbre mouvements: {movementComponent.movements.Count}");
    }

    //// Update is called once per frame
    //void Update()
    //{
        
    //}
}
