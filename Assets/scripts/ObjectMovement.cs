using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    //public float speed;

    //public Vector3 direction;

    public enum MovementType
    {
        Rotation,
        Translation
    }

    public MovementType movementType;

    // [System.Serializable] = permet à Unity d'utiliser la struct
    [System.Serializable]
    public struct Movement
    {
        public MovementType type;
        public float speed;
        public Vector3 direction;
        public Space espace;
    }

    public List<Movement> movements;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       foreach (Movement moove in movements)
        {
            

            if (moove.type == MovementType.Rotation)
            {
                transform.Rotate(moove.direction.normalized * moove.speed * Time.deltaTime, moove.espace);
            }
            else if (moove.type == MovementType.Translation)
            {
                transform.Translate(moove.direction.normalized * moove.speed * Time.deltaTime, moove.espace);
            }
        }
       

        //switch (moove.Type)
        // {
        //     case MovementType.Rotation:
        //         transform.Rotate(moove.direction * moove.speed * Time.deltaTime, Space.World)
        //         break;
        //     case MovementType.Translation:
        //         transform.Translate(moove.direction * moove.speed * Time.deltaTime, Space.World)
        //         break;
        // }
    }
}
