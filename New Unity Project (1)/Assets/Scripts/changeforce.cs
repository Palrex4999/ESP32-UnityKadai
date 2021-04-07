using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeforce : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject left;
    public GameObject right;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float angle = udptest.f_buf[0]; //傾ける角度
        //Debug.Log(angle);
        float normal = 30.0f;
        if(angle <= 0) {
            float force = normal + 5.0f * angle / 90;
            left.GetComponent<ConstantForce2D>().relativeForce = new Vector2(0, force);
            right.GetComponent<ConstantForce2D>().relativeForce = new Vector2(0,normal);
        } else {
            float force = normal - 5.0f * angle / 90;
            left.GetComponent<ConstantForce2D>().relativeForce = new Vector2(0,normal);
            right.GetComponent<ConstantForce2D>().relativeForce = new Vector2(0,force);
        }


    }
}
