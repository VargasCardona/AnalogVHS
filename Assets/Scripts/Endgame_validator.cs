using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Endgame_validator : MonoBehaviour
{
    public TextMeshProUGUI textToShow;
    UnityEngine.Video.VideoPlayer actualVideo;
    public float displayDuration = 2f;

    void Start()
    {
        textToShow.gameObject.SetActive(false);
        actualVideo = GetComponent<UnityEngine.Video.VideoPlayer>();
    }

    void Update(){
         actualVideo.loopPointReached += EndReached;
    }

    private void OnTriggerEnter(Collider obj)
    {
        if (obj.gameObject.CompareTag("Player")){ 
            if (Vhs_manager.vhsFound < 12)  
            {
                StartCoroutine(ShowTextCoroutine("I can't go out yet."));
            } else {
                actualVideo.Play();
            }
        }
    
    }

    IEnumerator ShowTextCoroutine(string textContent)
    {
        textToShow.text = textContent;

        textToShow.gameObject.SetActive(true);

        yield return new WaitForSeconds(displayDuration);

        textToShow.gameObject.SetActive(false);
    }

    void EndReached(UnityEngine.Video.VideoPlayer vp)
    {
        actualVideo.Stop();  
        Destroy(this);
        Application.Quit();
    }
}