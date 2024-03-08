using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Paddle playerPaddle;
    public Paddle computerPaddle;

    public Text playerScoreText;
    public Text computerScoreText;
    
    public int _playerScore;
    public int _computerScore;

    private int _currentScore;

    public GameObject _menu;
    public GameObject _lose;
    public GameObject _powerUp;

    public UpgradeSystem upgradeSystem;

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            _menu.SetActive(true);
            Time.timeScale = 0;
        }
        if (_playerScore >= 3)
        {
            _playerScore = 0;
            _computerScore = 0;
            this.playerScoreText.text = _playerScore.ToString();
            this.computerScoreText.text = _computerScore.ToString();
            ResetRound();
        }
        if (_computerScore >= 3)
        {
            _playerScore = 0;
            _computerScore = 0;
            this.playerScoreText.text = _playerScore.ToString();
            this.computerScoreText.text = _computerScore.ToString();
            ResetRound();
        }
    }

    public void PlayerScores()
    {
        Debug.Log("Player scores");
        _playerScore++;
        this.playerScoreText.text = _playerScore.ToString();

        if (_playerScore >= 3)
        {
            PowerUpPanel(true);
            UpgradeShuffle();
            Time.timeScale = 0;
            _currentScore++;
            
        }
        else
        {
            ResetRound();
        }
    }

    public void ComputerScores()
    {
        Debug.Log("Computer scores");
        _computerScore++;
        this.computerScoreText.text = _computerScore.ToString();

        if (_computerScore >= 3)
        {
            _lose.SetActive(true);
            Time.timeScale = 0;
            NewHighScore();
        }
        else {
            ResetRound();
        }
        
    }

    private void ResetRound()
    {
        this.ball.ResetPosition();
        this.playerPaddle.ResetPosition();
        this.computerPaddle.ResetPosition();
        this.ball.AddStartingForce();
    }

    public void TimeResume()
    {
        Time.timeScale = 1;
    }

    public void PowerUpPanel(bool active)
    {
        if(active == true) 
        {
            _powerUp.SetActive(true);
        }
    }

    public void UpgradeShuffle()
    {
        upgradeSystem.GetComponent<UpgradeSystem>().AssignUpgradeToObjects();
    }

    public void NewHighScore()
    {
        int highScore = PlayerPrefs.GetInt("HighScore");
        if (_currentScore > highScore)
        {
            // save current score as new high score
            PlayerPrefs.SetInt("HighScore", _currentScore);
            Debug.Log("New high score: " + _currentScore);
        }
    }
}
