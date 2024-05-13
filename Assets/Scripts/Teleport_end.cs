using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport_end : MonoBehaviour
{
    UnityEngine.Video.VideoPlayer actualVideo;
    public AudioSource finalSong;

    void Start()
    {
          actualVideo = GetComponent<UnityEngine.Video.VideoPlayer>();
          
    }

    void Update()
    {
        actualVideo.loopPointReached += EndReached;
    }

    private void OnTriggerEnter(Collider obj)
    {
        if (obj.gameObject.CompareTag("Player")){   
            actualVideo.Play();  
            finalSong.Play();
            obj.transform.position = new Vector3(-99.3f, 2.15f, 45.1200f);
            Destroy(this);  
        }
    }

    void EndReached(UnityEngine.Video.VideoPlayer vp)
    {
        actualVideo.Stop();  
    }
}
