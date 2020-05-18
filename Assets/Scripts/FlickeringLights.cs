using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickeringLights : MonoBehaviour
{
    private Light lights;
   
    void Start()
    {
        lights = this.gameObject.GetComponent<Light>();
        StartCoroutine("flicker");  
    }

    IEnumerator flicker ()
    {
        while (true)
        {
            lights.enabled = false;
            float wait = Random.Range(0.4f, 0.9f);
            yield return new WaitForSeconds(wait);
            lights.enabled = true;
            wait = Random.Range(0.4f, 0.9f);
            yield return new WaitForSeconds(wait);
        }
    }
}
