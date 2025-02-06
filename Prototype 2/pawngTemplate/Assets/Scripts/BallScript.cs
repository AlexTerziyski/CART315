using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.UI;

public class BallScript : MonoBehaviour
{
    private Rigidbody2D rb;
    public float ballSpeed = 2;
    public float maxSpeed = 10f;
    public float minSpeed = 2f;

    public AudioSource scoreSound, blip;

    public int leftPlayerScore, rightPlayerScore;

    private int[] dirOptions = { -1, 1 };
    private int hDir, vDir;

    private Renderer ballRenderer; // Reference to the Renderer component for changing color

    public float sizeMultiplier = 1.1f; // Multiplier for increasing ball size

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        ballRenderer = GetComponent<Renderer>(); // Get the Renderer component
        StartCoroutine(Launch());
    }

    // Start the Ball Moving
    private IEnumerator Launch()
    {
        // Figure out directions
        hDir = dirOptions[Random.Range(0, dirOptions.Length)];
        vDir = dirOptions[Random.Range(0, dirOptions.Length)];

        // Add a horizontal force
        rb.AddForce(transform.right * ballSpeed * hDir); // Randomly go Left or Right
        // Add a vertical force
        rb.AddForce(transform.up * ballSpeed * vDir); // Randomly go Up or Down

        yield return new WaitForSeconds(1.5f);

        yield return null;
    }

    public void Reset()
    {
        rb.linearVelocity = Vector2.zero;
        transform.position = new Vector3(0, 0, 0);
        StartCoroutine(Launch());
    }

    public void IncrementScore()
    {
        GameObject.Find("leftScore").GetComponent<Text>().text = leftPlayerScore.ToString();
        GameObject.Find("rightScore").GetComponent<Text>().text = rightPlayerScore.ToString();
    }

    // If the ball goes out of bounds
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Wall") || other.gameObject.CompareTag("Paddle"))
        {
            blip.pitch = (other.gameObject.CompareTag("Wall")) ? 0.75f : 1f;
            blip.Play();
            SpeedCheck(); // Increase speed on every bounce

            ChangeBallColor(); // Change the ball color when hitting a wall or paddle
            IncreaseBallSize(); // Increase the ball size on every hit
        }

        if (other.gameObject.name == "leftWall")
        {
            rightPlayerScore++;
            IncrementScore();
            Reset();
        }

        if (other.gameObject.name == "rightWall")
        {
            leftPlayerScore++;
            IncrementScore();
            Reset();
        }
    }

    private void SpeedCheck()
    {
        float speedMultiplier = 1.25f; // Increase speed by 5% on each bounce

        // Get the current velocity
        Vector2 velocity = rb.linearVelocity;

        // Increase the speed while maintaining the direction
        velocity *= speedMultiplier;

        // Clamp the velocity to ensure it doesn't exceed maxSpeed
        float newSpeed = velocity.magnitude;
        if (newSpeed > maxSpeed)
        {
            velocity = velocity.normalized * maxSpeed; // Normalize to keep direction, but cap speed
        }

        rb.linearVelocity = velocity; // Apply new velocity

        Debug.Log("New Ball Speed: " + rb.linearVelocity.magnitude);
    }

    // Method to change the ball's color randomly
    private void ChangeBallColor()
    {
        // Generate a random color (R, G, B, A)
        Color randomColor = new Color(Random.value, Random.value, Random.value);

        // Set the ball's color to the new random color
        ballRenderer.material.color = randomColor;
    }

    // Method to increase the ball's size
    private void IncreaseBallSize()
    {
        // Scale the ball by the size multiplier
        transform.localScale *= sizeMultiplier;

        // Optionally, clamp the size to a maximum limit to avoid the ball becoming too large
        if (transform.localScale.x > 3f) // Set a maximum size limit (example: 3x the original size)
        {
            transform.localScale = new Vector3(3f, 3f, 3f);
        }
    }
}
