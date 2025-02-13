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
        ExtraLife
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
}