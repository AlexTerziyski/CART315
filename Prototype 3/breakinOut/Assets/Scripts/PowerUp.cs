using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    [SerializeField] private PowerUpType type;
    [SerializeField] private GameObject multiBallPrefab;

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
        if (multiBallPrefab != null)
        {
            Debug.Log("Attempting to spawn multi balls");

            // Spawn two balls at slightly offset positions
            Vector3 centerPos = new Vector3(0, 0, 0);
            Vector3 leftPos = centerPos + new Vector3(-0.5f, 0, 0);
            Vector3 rightPos = centerPos + new Vector3(0.5f, 0, 0);

            // Create the balls
            GameObject ball1 = Instantiate(multiBallPrefab, leftPos, Quaternion.identity);
            GameObject ball2 = Instantiate(multiBallPrefab, rightPos, Quaternion.identity);

            // Setup their movement
            SetupMultiBall(ball1, new Vector2(-0.5f, -1f));
            SetupMultiBall(ball2, new Vector2(0.5f, -1f));

            Debug.Log("Multi balls spawned");
        }
        else
        {
            Debug.LogError("MultiBall prefab is not assigned!");
        }
    }

    private void SetupMultiBall(GameObject ball, Vector2 direction)
    {
        Rigidbody2D rb = ball.GetComponent<Rigidbody2D>();
        BreakoutBall ballScript = ball.GetComponent<BreakoutBall>();

        if (rb != null && ballScript != null)
        {
            ballScript.canLoseLife = false;
            float speed = 5f;
            rb.linearVelocity = direction.normalized * speed;
            Debug.Log($"Ball velocity set to: {rb.linearVelocity}");
        }
    }
}