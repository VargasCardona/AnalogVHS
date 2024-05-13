using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadCredits : MonoBehaviour
{
    public GameObject credits;
    public GameObject menu;
    public GameObject tutorial;

    void Start()
    {
        
        float duration = 5f;
        StartCoroutine(TestRoutine(duration, credits, menu, tutorial));
        
    }

    void Update()
    {
        
    }

    IEnumerator TestRoutine(float duration, GameObject credits, GameObject menu, GameObject tutorial)
    {
        Debug.Log("Start");
        menu.gameObject.SetActive(false);
        tutorial.gameObject.SetActive(false);
        yield return new WaitForSeconds(duration);
        credits.gameObject.SetActive(false);
        menu.gameObject.SetActive(true);
        Debug.Log("End");
    }

}
