using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject playerObj;
    void Start()
    {

    }
    void Update()
    {
        transform.position = new Vector3(playerObj.transform.position.x, playerObj.transform.position.y+2.5f, -10);
    }
}
