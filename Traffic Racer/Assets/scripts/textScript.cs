using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textScript : MonoBehaviour
{
    public Text score;
    public Text finishscore;
    public Text highScore;
    public GameObject realscore;
    public GameObject gameoverscene;
    public GameObject duringGame;

    float scoree;
    float counter;
    int multiplier = 1;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        duringGame.SetActive(true);
        gameoverscene.SetActive(false);
        scoree = 0;
    }

    // Update is called once per frame
    void Update()
    {



        counter += Time.deltaTime;
        if(counter > 3)
        {
            counter = 0;
            multiplier++;
        }

        scoree += (Time.deltaTime) * multiplier;
        if(scoree > PlayerPrefs.GetFloat("high", 0))
        {
            PlayerPrefs.SetFloat("high", scoree);
        }
        score.text = "SCORE : " + ((int)scoree).ToString();
        finishscore.text = "SCORE : " + ((int)scoree).ToString();
        highScore.text = "BEST : " + ((int)PlayerPrefs.GetFloat("high")).ToString();

    }
    public void GameOverScreen()
    {
        duringGame.SetActive(false);
        gameoverscene.SetActive(true);
        Time.timeScale = 0;

    }
}
