using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text scoreText;
    public Text highscoreText;
    public static int highscore;
    public static int nowscore = 0;

    private string key = "HIGH SCORE";
    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt(key, 0); 
        highscoreText.text = "HighScore: " + highscore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        nowscore = (int)transform.position.y;
        //Debug.Log(nowscore);
        scoreText.text = "SCORE : " + nowscore; 

        if(nowscore > highscore){
            highscore = nowscore;
            PlayerPrefs.SetInt(key, highscore);
            highscoreText.text = "HighScore: " + highscore.ToString();
        }
    }

    public static int getscore(){
        return nowscore;
    }

    public static int gethighscore(){
        return highscore;
    }
}
