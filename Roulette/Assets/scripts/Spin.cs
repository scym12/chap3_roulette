using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spin : MonoBehaviour {

    public float rotSpeed = 0;
    public bool isRotate = false;

    public int score = 0;
    public GameObject objScore;

    public int[] arrScore = { 5, 1000, 10, 10000, 1, 5000, 50, 8000 };
    public int[] arrCircle = { 0 , 45, 90, 135, 180, 225, 270, 315, 360 };


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, this.rotSpeed);

        objScore.GetComponent<Text>().text = "Score : " + score;
        //Debug.Log(transform.eulerAngles.z);
        if (this.rotSpeed < 0.01)
        {
            this.rotSpeed = 0;
            if(this.isRotate == true)
            {
                int scr = arrScore[0] ;
                int tmp = (int)transform.eulerAngles.z / 360;
                float arc = transform.eulerAngles.z - (360 * tmp);
                
                for (int i = 1; i < arrCircle.Length; i++)
                {
                    if (arc >= arrCircle[i - 1] && arc <= arrCircle[i])
                    {
                        scr = arrScore[i];
                        break;
                    }
                }
                this.score += scr;
                this.isRotate = false;
            }
        }
        else
            this.rotSpeed *= 0.96f;
    }

    public void spin()
    {
        if(this.isRotate == false)
        {
            this.rotSpeed = Random.Range(20, 80);
            this.isRotate = true;

        }
    }
}
