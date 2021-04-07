using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameover : MonoBehaviour
{
    public Text scoreText;
    public Text highscoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(score.getscore());
        scoreText.text = "SCORE: " + score.getscore();
        highscoreText.text = "HighScore: " + score.gethighscore();
    }


}
