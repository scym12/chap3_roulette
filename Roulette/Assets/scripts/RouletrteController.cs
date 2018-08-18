using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletrteController : MonoBehaviour {

    public float rotSpeed = 0;
       
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 30;
        }

        transform.Rotate(0, 0, this.rotSpeed);

        if (this.rotSpeed < 0.01)
            this.rotSpeed = 0;
        else
            this.rotSpeed *= 0.96f;
	}
}
