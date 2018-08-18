﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CiclularProgress : MonoBehaviour {

    public int timeToComplete = 3;
 
// Use this for initialization
void Start()
    {
        //Use this to Start progress
        StartCoroutine(RadialProgress(timeToComplete));
    }

    IEnumerator RadialProgress(float time)
    {
        float rate = 1 / time;
        float i = 0;
        while (i < 1)
        {
            i += Time.deltaTime * rate;
            gameObject.GetComponent<Renderer>().material.SetFloat("_Cutoff", i);
            yield return 0;
        }
    }
}
