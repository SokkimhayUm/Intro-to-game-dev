using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    private int i = 3;
    private int disableFrame;

    void Start()
    {
        if (gameObject.tag == "Blue")
        {
            disableFrame = Random.Range(150, 251);
        }
    }
    void Update()
    {
        i++;

        UnityEngine.Debug.Log(gameObject.name + ":" + i);


        if (gameObject.tag == "Red" && i == 100)
        {
            gameObject.SetActive(false);
        }
        else if (gameObject.tag == "Blue" && i == disableFrame)
        {
            rend.enabled = false;
        }
    }
}