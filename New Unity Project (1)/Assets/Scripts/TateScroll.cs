using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class TateScroll : MonoBehaviour
{
    public GameObject core;
    //スクロールスピード
   
   void Update()
   {
        if(core.transform.position.y - transform.position.y > 10){
            transform.position = new Vector2(0, core.transform.position.y + 11.22f);
        }
    }
}