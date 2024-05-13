using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinning_vhs : MonoBehaviour
{
    UnityEngine.Video.VideoPlayer actualVideo;

    public float xCoord;
    public float yCoord;
    public float zCoord;
    public GameObject effect;
    public GameObject vhsShader;
    

    private bool isProcessed = false;
    private bool alreadyInstantitated = false;

    void Start()
    {
          actualVideo = GetComponent<UnityEngine.Video.VideoPlayer>();
          
    }

    void Update()
    {
        actualVideo.loopPointReached += EndReached;
        transform.Rotate(35 * Time.deltaTime, 35 * Time.deltaTime, 0f, Space.Self);
    }

    private void OnTriggerEnter(Collider obj)
    {
        if (obj.gameObject.CompareTag("Player") && !isProcessed){   
            Vhs_manager.vhsFound += 1;
            actualVideo.Play();  
            isProcessed = true;
            //float duration = 5f;
            //StartCoroutine(TestRoutine(duration));  
            //obj.transform.position = new Vector3(xCoord, yCoord, zCoord);
            Instantiate(effect, this.transform.position, Quaternion.Euler(-90f, 0f, 0f));
            
        }
    }

    void EndReached(UnityEngine.Video.VideoPlayer vp)
    {
        actualVideo.Stop();  

        Vector3 newPosition = transform.position;
        if (!alreadyInstantitated)
        {
            Instantiate(
                    vhsShader,
                    new Vector3(newPosition.x * 0.14f, -13.4f, newPosition.z * 0.14f),
                    Quaternion.identity);
            alreadyInstantitated = true;
        }
        Destroy(this);
        Destroy(gameObject);
    }

    IEnumerator TestRoutine(float duration)
{
    yield return new WaitForSeconds(duration);
}
}
