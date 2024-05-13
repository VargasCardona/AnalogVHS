using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlerCube : MonoBehaviour {


	public float speed;

    float rotX, rotY, rotZ;
    
	void Start () {

	rotX = 0;
	rotY = 0;
	rotZ = 0;
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

	manyKeys();
	useVel ();

	}

	private void manyKeys()
    {
        float hor = 0;
        float ver = 0;
        float yAxis = 0;
       
        if (Input.GetKeyDown("a"))
            hor = -1;
        if (Input.GetKeyDown("d"))
            hor = 1;
        if (Input.GetKeyDown("w"))
            ver = 1;
        if (Input.GetKeyDown("s"))
            ver = -1;
        if (Input.GetKey("q"))
            rotY += 5;
        if (Input.GetKey("e"))
            rotY -= 5;
        if (Input.GetKey("r"))
            yAxis = 3;


        transform.rotation = Quaternion.Euler(rotX, rotY, rotZ);
        Vector3 vel = new Vector3(hor, yAxis, ver);
       
        GetComponent<Transform>().position += vel * speed * Time.deltaTime;
    }


 private void useVel()
    {
        float hor = 0;
        float ver = 0;
        if (Input.GetKey("a"))
            hor = -1;
        if (Input.GetKey("d"))
            hor = 1;
        if (Input.GetKey("w"))
            ver = 1;
        if (Input.GetKey("s"))
            ver = -1;
        Vector3 vel = new Vector3(hor, 0, ver);
     
        GetComponent<Transform>().position+=vel*speed* Time.deltaTime;
	 
 }
	 
	void OnCollisionEnter(Collision other) {
		
		if (other.gameObject.tag == "Vida"){
			Destroy (other.gameObject);
		} 

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Potion")
        {
            Destroy(this.gameObject);
        }

    }

}
