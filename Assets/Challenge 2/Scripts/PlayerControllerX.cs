using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private System.DateTime lastUpdateTime = System.DateTime.Now;
    private bool firstTimeGenerate = true;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && checkSpawn(lastUpdateTime))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            lastUpdateTime = System.DateTime.Now;
            firstTimeGenerate = false;
        }
    }

    bool checkSpawn(System.DateTime lastUpdateTime)
    {
        if (firstTimeGenerate)
        {
            return true;
        }
        System.TimeSpan delayTime = System.DateTime.Now - lastUpdateTime;
        if (delayTime.TotalSeconds > 2)
        {
            return true;
        }
        return false;
    }
}
