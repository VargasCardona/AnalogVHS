using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Vhs_manager : MonoBehaviour
{
    public TextMeshProUGUI vhsTextCounter;
    public static int vhsFound;

    void Start()
    {
        vhsFound = 0;
    }

    void Update()
    {
        vhsTextCounter.text =  vhsFound + " / 12";
    }
}
