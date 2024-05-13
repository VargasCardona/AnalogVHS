using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroVideo : MonoBehaviour
{
    UnityEngine.Video.VideoPlayer actualVideo;
    public GameObject tutorial;

    void Start()
    {
        actualVideo = GetComponent<UnityEngine.Video.VideoPlayer>();
        actualVideo.loopPointReached += EndReached;
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void ContinueIntro()
    {
        actualVideo.Play();
    }

    void EndReached(UnityEngine.Video.VideoPlayer vp)
    {
        float duration = 5f;
        StartCoroutine(TestRoutine(duration, tutorial));
        StartCoroutine(LoadSceneAsync());
        actualVideo.Stop();
        Destroy(this);
        Destroy(gameObject);
        
        
    }

    IEnumerator TestRoutine(float duration, GameObject tutorial)
    {
        tutorial.gameObject.SetActive(true);
        yield return new WaitForSeconds(duration);
        tutorial.gameObject.SetActive(false);
    }

    private IEnumerator LoadSceneAsync()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(1);

        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}