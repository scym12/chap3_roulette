using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressExam : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        float revealOffset = (float)(Time.timeSinceLevelLoad % 10) / 10.1F;
        Debug.Log(revealOffset);
        gameObject.GetComponent<Renderer>().material.SetFloat("_Cutoff", revealOffset);
    }
}
