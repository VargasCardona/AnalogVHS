using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAmbiance : MonoBehaviour
{

    UnityEngine.Video.VideoPlayer actualVideo;
    public AudioSource backgroundMusic;

    void Start()
    {
          actualVideo = GetComponent<UnityEngine.Video.VideoPlayer>();
          
    }

    void Update(){
         actualVideo.loopPointReached += EndReached;
    }

    private void OnTriggerEnter(Collider obj)
    {
        if (obj.gameObject.CompareTag("Player")){   
            actualVideo.Play();    
        }
    }

    void EndReached(UnityEngine.Video.VideoPlayer vp)
    {
        actualVideo.Stop();  
        Destroy(this);
        Debug.Log("HEY");
    }
}