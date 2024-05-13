using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTutorial : MonoBehaviour
{
    public GameObject tutorial;
    public GameObject map;

    void Start()
    {
        map.gameObject.SetActive(false);
        float duration = 3f;
        StartCoroutine(TestRoutine(duration, tutorial));
        
    }

    void Update()
    {
        
    }

    IEnumerator TestRoutine(float duration, GameObject tutorial)
    {
        tutorial.gameObject.SetActive(true);
        yield return new WaitForSeconds(duration);
         tutorial.gameObject.SetActive(false);
    }
}
