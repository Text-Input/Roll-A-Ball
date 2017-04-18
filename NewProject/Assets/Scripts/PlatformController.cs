using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour {

    public float Speed;
    private Vector3 rotation;
    
    // Use this for initialization
    void Start() {
        rotation = transform.rotation.eulerAngles;
    }

    void FixedUpdate() {
        float rotateHorizontal = Input.GetAxis("altHorizontal");
        float rotateVertical = Input.GetAxis("altVertical");

        rotation.x = rotation.x + (rotateVertical * Speed);
        rotation.z = rotation.z + (-rotateHorizontal * Speed);

        rotation.x = Mathf.Clamp(rotation.x, -50, 50);
        rotation.z = Mathf.Clamp(rotation.z, -50, 50);
        
        transform.rotation = Quaternion.Euler(rotation.x, 0.0f, rotation.z);
        
    }
}
