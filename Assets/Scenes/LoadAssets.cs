using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    public GameObject redObj;
    [SerializeField] private GameObject blueObj;


    // Start is called before the first frame update
    void Start()
    {
        GameObject redInstance = Instantiate(redObj, new Vector3(2, 0, 0), Quaternion.identity);
        GameObject blueInstance = Instantiate(blueObj, new Vector3(-2, 0, 0), Quaternion.identity);

        Application.targetFrameRate = 60;

        redInstance.name = "RedPrefab(Clone)";
        blueInstance.name = "BluePrefab(Clone)";

        redInstance.tag = "Red";
        blueInstance.tag = "Blue";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
