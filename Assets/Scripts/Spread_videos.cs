using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spread_videos : MonoBehaviour
{
    public GameObject vhs01;
    Vector3[] positions01 = new Vector3[] {
        new Vector3(-56.28f, 4.03f, 35.82f),
        new Vector3(-53.09f, 4.04f, 15.01f),
        new Vector3(-71.05f, 4.04f, 20.81f)
        }; 
    public GameObject vhs02;
    Vector3[] positions02 = new Vector3[] {
        new Vector3(-50.118f, 4.04f, 29.68f),
        new Vector3(-38.34f, 4.04f, 14.97f),
        new Vector3(-28.97f, 4.04f, 20.87f)
        }; 
    public GameObject vhs03;
    Vector3[] positions03 = new Vector3[] {
        new Vector3(-56.25f, 4.03f, 15.03f),
        new Vector3(-35.09f, 4.03f, 14.87f),
        new Vector3(-35.97f, 4.04f, 5.90f)
        }; 
    public GameObject vhs04;
    Vector3[] positions04 = new Vector3[] {
        new Vector3(-53.04f, 4.04f, 3.04f),
        new Vector3(-35.15f, 4.04f, 36.18f),
        new Vector3(-64.90f, 4.04f, 21.04f)
        }; 
    public GameObject vhs05;
    Vector3[] positions05 = new Vector3[] {
        new Vector3(-71.17f, 4.04f, -12.59f),
        new Vector3(-68.03f, 4.04f, -5.49f),
        new Vector3(-62.00f, 4.04f, -3.31f)
        }; 
    public GameObject vhs06;
    Vector3[] positions06 = new Vector3[] {
        new Vector3(-41.13f, 4.04f, -15.45f),
        new Vector3(-34.99f, 4.04f, -27.45f),
        new Vector3(-26.03f, 4.04f, -27.45f)
        }; 
    public GameObject vhs07;
    Vector3[] positions07 = new Vector3[] {
        new Vector3(-10.63f, 4.04f, -18.18f),
        new Vector3(4.31f, 4.04f, -18.18f),
        new Vector3(1.118f, 4.04f, -9.28f)
        }; 
    public GameObject vhs08;
    Vector3[] positions08 = new Vector3[] {
        new Vector3(-11.42f, 4.04f, 14.89f),
        new Vector3(-17.42f, 4.04f, 14.97f),
        new Vector3(-14.433f, 4.04f, -3.29f)
        }; 
    public GameObject vhs09;
    Vector3[] positions09 = new Vector3[] {
        new Vector3(-28.93f, 4.04f, 27.06f),
        new Vector3(-38.34f, 4.04f, 41.61f),
        new Vector3(-23.21f, 4.04f, 44.78f)
        }; 
    public GameObject vhs10;
    Vector3[] positions10 = new Vector3[] {
        new Vector3(7.08f, 4.04f, 33.00f),
        new Vector3(6.89f, 4.04f, 29.49f),
        new Vector3(-8.23f, 4.04f, 29.49f)
        }; 
    public GameObject vhs11;
    Vector3[] positions11 = new Vector3[] {
        new Vector3(-43.67f, 4.04f, 5.859f),
        new Vector3(-40.88f, 4.04f, -0.28f),
        new Vector3(-31.97f, 4.04f, 6.16f)
        }; 
    public GameObject vhs12;
    Vector3[] positions12 = new Vector3[] {
        new Vector3(-20.23f, 4.04f, 20.82f),
        new Vector3(-38.34f, 4.04f, 11.793f),
        new Vector3(-26.157f, 4.04f, -0.62f)
        }; 

    public GameObject vhsMarker;
    public  bool alreadyCompiled = false;

    public GameObject map;
    public GameObject camera;

    private void OnTriggerEnter(Collider obj)
    {
        GameObject[] vhs  = new GameObject[]{
            vhs01, vhs02,vhs03, vhs04, vhs05, vhs06,
            vhs07, vhs08, vhs09, vhs10, vhs11, vhs12
        };

        Vector3[][] positions = new Vector3[][]{
            positions01, positions02, positions03, positions04, positions05, positions06,
            positions07, positions08, positions09, positions10, positions11, positions12
        };
 
        if (obj.gameObject.CompareTag("Player") && !alreadyCompiled){   
            for (int i = 0; i < vhs.Length; i++)
            {
                int randInt = Random.Range(0, 3);
                
                Vector3 newPosition = positions[i][randInt];
                Instantiate(
                    vhsMarker,
                    new Vector3(newPosition.x * 0.14f, -13.6f, newPosition.z * 0.14f),
                    Quaternion.identity);
                Debug.Log("Iteration no : [" + (i+1) + "]: ");
                vhs[i].transform.position = newPosition;
            }
            alreadyCompiled = true;
        }

        float duration = 3f;
        StartCoroutine(TestRoutine(duration, map, camera));
    
    }

    IEnumerator TestRoutine(float duration, GameObject map, GameObject camera)
    {
        camera.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        camera.gameObject.SetActive(false);
        map.gameObject.SetActive(true);
        yield return new WaitForSeconds(duration);
        map.gameObject.SetActive(false);
    }
}
