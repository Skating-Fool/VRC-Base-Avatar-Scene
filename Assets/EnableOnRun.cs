using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableOnRun : MonoBehaviour
{

    public GameObject[] objectsToEnable;
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject obj in objectsToEnable)
        {
            obj.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
