using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightCollision : MonoBehaviour
{
    public GameObject udpobj;
    private byte[] vib_on = {0x3c, 0x00, 0x00, 0x00};
    private byte[] vib_off = {0x00, 0x00, 0x00, 0x00};
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D c)
    {   

        //壁に接触かつjointがとれていないとき
        if(c.gameObject.tag == "Wall"){
            Debug.Log("collision!!!!");
            udpobj.GetComponent<udptest>().senddataUDP(vib_on);
            Invoke(nameof(send_off), 0.5f); //1秒後に振動オフ
        }
    }

    void send_off(){
        udpobj.GetComponent<udptest>().senddataUDP(vib_off);
    }
}
