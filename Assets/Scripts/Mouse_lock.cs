using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse_lock : MonoBehaviour
{
    void Update()
    {
    	if (Input.GetKeyDown("1"))
    	{
  	     UnityEngine.Cursor.lockState = CursorLockMode.Locked;
   	     UnityEngine.Cursor.visible = false;
   	     Debug.Log ("Lock");
    	}
    	
        if (Input.GetKeyDown("2"))
    	{
  	     UnityEngine.Cursor.lockState = CursorLockMode.None;
   	     UnityEngine.Cursor.visible = true;
   	     Debug.Log ("Unlock");
    	}
    }
}
