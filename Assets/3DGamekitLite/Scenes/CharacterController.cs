using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour

float maxSpeed = 3.0f;
float rotation = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (transform.forward * Input.GetAxis("Vertical"));

        RotationDriveMode = rotation + Input.GetAxis("Mouse X");
        Transform.rotation = Quaternion.Euler(new Vector3(0.0f, RotationDriveMode, 0.0f));
       }
}
