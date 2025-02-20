using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    [SerializeField] private PowerUpType type;

    public enum PowerUpType
    {
        ExtendPaddle,
        SpeedUp,
        ExtraLife,
        MultiBall
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision detected with: " + other.gameObject.name);
        if (other.gameObject.CompareTag("Ball"))
        {
            ApplyPowerUp();
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger detected with: " + other.gameObject.name);
        if (other.CompareTag("Ball"))
        {
            ApplyPowerUp();
            Destroy(gameObject);
        }
    }

    private void ApplyPowerUp()
    {
        switch (type)
        {
            case PowerUpType.ExtendPaddle:
                GameObject paddle = GameObject.FindGameObjectWithTag("Paddle");
                if (paddle != null)
                {
                    Vector3 currentScale = paddle.transform.localScale;
                    paddle.transform.localScale = new Vector3(currentScale.x * 1.5f, currentScale.y, currentScale.z);
                    StartCoroutine(ResetPaddleSize(paddle));
                }
                break;

            case PowerUpType.SpeedUp:
                GameObject ball = GameObject.FindGameObjectWithTag("Ball");
                if (ball != null)
                {
                    BreakoutBall ballScript = ball.GetComponent<BreakoutBall>();
                    if (ballScript != null)
                    {
                        ballScript.ballSpeed *= 1.5f;
                        StartCoroutine(ResetBallSpeed(ballScript));
                    }
                }
                break;

            case PowerUpType.ExtraLife:
                GameManager.S.lives++;
                GameManager.S.heartImage.fillAmount = (GameManager.S.lives * .2f);
                break;

            case PowerUpType.MultiBall:
                Debug.Log("Starting MultiBall spawn process");
                SpawnMultiBall();
                break;

        }
    }

    private IEnumerator ResetPaddleSize(GameObject paddle)
    {
        yield return new WaitForSeconds(5f);
        if (paddle != null)
        {
            Vector3 currentScale = paddle.transform.localScale;
            paddle.transform.localScale = new Vector3(currentScale.x / 1.5f, currentScale.y, currentScale.z);
        }
    }

    private IEnumerator ResetBallSpeed(BreakoutBall ball)
    {
        yield return new WaitForSeconds(5f);
        if (ball != null)
        {
            ball.ballSpeed /= 1.5f;
        }
    }

    private void SpawnMultiBall()
    {
        // Find the original ball prefab
        GameObject originalBall = GameObject.FindGameObjectWithTag("Ball");
        if (originalBall != null)
        {
            Debug.Log("Found original ball, creating multi balls");

            // Create two new balls at center of screen
            Vector3 centerPosition = new Vector3(0, 0, 0);

            // Spawn first ball
            GameObject newBall1 = Instantiate(originalBall, centerPosition, Quaternion.identity);
            SetupMultiBall(newBall1, new Vector2(-0.5f, -1f));  // Goes left and down

            // Spawn second ball
            GameObject newBall2 = Instantiate(originalBall, centerPosition, Quaternion.identity);
            SetupMultiBall(newBall2, new Vector2(0.5f, -1f));   // Goes right and down
        }
    }
    private void SetupMultiBall(GameObject ball, Vector2 direction)
    {
        Debug.Log("Setting up multi ball");

        // Make it smaller
        ball.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);

        // Make it gray
        SpriteRenderer renderer = ball.GetComponent<SpriteRenderer>();
        if (renderer != null)
        {
            renderer.color = Color.gray;
        }

        // Set up physics and properties
        Rigidbody2D rb = ball.GetComponent<Rigidbody2D>();
        BreakoutBall ballScript = ball.GetComponent<BreakoutBall>();

        if (rb != null && ballScript != null)
        {
            ballScript.canLoseLife = false;  // Won't affect lives

            // Set velocity
            float speed = 5f;  // Fixed speed for multi balls
            rb.linearVelocity = direction.normalized * speed;

            Debug.Log($"Ball velocity set to: {rb.linearVelocity}");
        }
    }
}