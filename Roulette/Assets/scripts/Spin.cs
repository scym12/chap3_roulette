using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour {

    public float rotSpeed = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, this.rotSpeed);

        if (this.rotSpeed < 0.01)
            this.rotSpeed = 0;
        else
            this.rotSpeed *= 0.96f;
    }

    public void spin()
    {
        this.rotSpeed = Random.Range(20, 50);
    }
}
