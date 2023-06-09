using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoretext;
    public TextMeshProUGUI displayName;

    void Start()
    {
        UpdateHighScore();
        UpdateName();
        
    }
    private void Update()
    {
        ShowScore();
    }
    public void Play()
    {

        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        SceneManager.LoadScene("GameScene");
        
    }

    public void Exit()
    {
        Application.Quit();
    }
    public void  ShowScore()
    { if(scoreText != null)
        scoreText.text = "Score: "+ Shooter.score;
    }
    public void GoBack()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
    public void UpdateHighScore()
    { 
        if(highScoretext!=null)
        highScoretext.text = "High Score: " + PlayerPrefs.GetInt("HighScore");
    }
    public void UpdateName()
    {
        if (displayName != null)
            displayName.text = "Name: " + PlayerPrefs.GetString("name");
    }
}
