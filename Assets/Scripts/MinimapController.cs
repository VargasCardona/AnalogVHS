using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapController : MonoBehaviour
{
    GameObject marker;
    void Start()
    {
        marker = GameObject.Find("MinimapPlayer");
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 playerPosition = GameObject.Find("Player").transform.position;
        Vector3 minimapPosition = new Vector3(playerPosition.x * 0.14f, -9.706f, playerPosition.z * 0.14f  );

        marker.transform.position = minimapPosition;

        RectTransform minimapPlayer = GameObject.Find("MinimapPlayer").GetComponent<RectTransform>();
        minimapPlayer.anchoredPosition = minimapPosition;

    }
}
