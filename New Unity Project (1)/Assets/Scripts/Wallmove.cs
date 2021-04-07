using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wallmove : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject rocket;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      this.transform.position = new Vector3(0.0f, rocket.transform.position.y+2.5f, 0);
    }
}
