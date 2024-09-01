using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    // Public GameObject variable to store the reference to the red object prefab
    public GameObject redObj;

    // Start is called before the first frame update
    void Start()
    {
        // Instantiate the red object at a specific position with no rotation
        Instantiate(redObj, new Vector3(2, 0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
