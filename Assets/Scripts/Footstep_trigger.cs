using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footstep_trigger : MonoBehaviour
{
    public AudioSource footStepsSound;

    void Update()
    {
       if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) ||Input.GetKey(KeyCode.D)){
           footStepsSound.enabled = true;
       } else {
           footStepsSound.enabled = false;
       }
    }
}
