using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftforce : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject right;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float angle = udptest.f_buf[0]; //傾ける角度
        if(angle < 0) {
            float force = 70.0f + 7 * angle / 9;
            this.gameObject.GetComponent<ConstantForce2D>().relativeForce.Set(0,force);
        }

    }
}
