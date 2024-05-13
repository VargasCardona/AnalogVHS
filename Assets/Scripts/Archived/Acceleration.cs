using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acceleration : MonoBehaviour
{
    Rigidbody rigidBody;
    Vector3 appliedForce;
    float xForce, yForce;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        appliedForce = new Vector3(-20.0f, 0.0f, 0.0f);

    }

    void FixedUpdate()
    {
        rigidBody.AddForce(appliedForce, ForceMode.Impulse);
    }

    //public physics(float xForce, float yForce)
    //{
    //   
    //}
}
