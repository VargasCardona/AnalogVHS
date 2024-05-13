using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyContact : MonoBehaviour
{

    Rigidbody rigidBody;
    Vector3 appliedForce;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        appliedForce = new Vector3(0.0f, 6.0f, 0.0f);

    }

    private void OnTriggerEnter(Collider obj)
    {
        if (obj.gameObject.CompareTag("Player")){
            gameObject.transform.position = new Vector3(25f, 0f, 0f);    
            rigidBody.AddForce(appliedForce, ForceMode.Impulse);  
        }
    }
}
