using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneMove : MonoBehaviour
{
    public GameObject b5; //
    public GameObject b6; //

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(b5.GetComponent<FixedJoint2D>() == null && b6.GetComponent<FixedJoint2D>() == null){
            // Debug.Log("FixedJoint2d is Deleted!");]
            
            Invoke(nameof(changeScene), 2.0f); //4秒後にシーン遷移
        }
    }

    void changeScene(){
        SceneManager.LoadScene("GameOver");
    }
}
