using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int lives;
    public int points;

    public Image heartImage;

    // Add new UI text references
    public TextMeshProUGUI livesText;
    public TextMeshProUGUI ballSpeedText;
    public TextMeshProUGUI paddleSizeText;
    public TextMeshProUGUI scoreText;

    public static GameManager S;

    void Awake()
    {
        S = this;
    }

    void Start()
    {
        lives = 4;
        UpdateUI(); // Add initial UI update
    }

    void Update()
    {
        // Get current ball speed and paddle size
        UpdateUI();
    }

    public void LoseLife()
    {
        lives--;
        heartImage.fillAmount = (lives * .2f);

        // Check if game over
        if (lives <= 0)
        {
            lives = 0;  // Prevent negative lives
                        // Add your game over logic here
            GameOver();
        }
    }

    private void GameOver()
    {
        // Pause the game
        Time.timeScale = 0;

        // Optional: Print game over message to console
        Debug.Log("Game Over!");
    }
    public void AddPoint(int numPoints)
    {
        points += numPoints;
        UpdateUI(); // Update UI when points are added
    }

    private void UpdateUI()
    {
        // Get current ball speed
        float currentBallSpeed = 0;
        GameObject ball = GameObject.FindGameObjectWithTag("Ball");
        if (ball != null)
        {
            BreakoutBall ballScript = ball.GetComponent<BreakoutBall>();
            if (ballScript != null)
            {
                currentBallSpeed = ballScript.ballSpeed;
            }
        }

        // Get current paddle size
        float currentPaddleSize = 1;
        GameObject paddle = GameObject.FindGameObjectWithTag("Paddle");
        if (paddle != null)
        {
            currentPaddleSize = paddle.transform.localScale.x;
        }

        // Update UI texts
        if (livesText != null) livesText.text = $"Lives: {lives}";
        if (ballSpeedText != null) ballSpeedText.text = $"Ball Speed: {currentBallSpeed:F2}";
        if (paddleSizeText != null) paddleSizeText.text = $"Paddle Size: {currentPaddleSize:F2}";
        if (scoreText != null) scoreText.text = $"Score: {points}";
    }
}