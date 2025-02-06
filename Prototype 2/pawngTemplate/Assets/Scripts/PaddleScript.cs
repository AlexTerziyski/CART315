using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    private float yPos;
    public float paddleSpeed = 5f;
    public float topWall, bottomWall;

    public KeyCode upKey, downKey;

    // Add the paddle size increment
    public float sizeIncreaseAmount = 0.5f; // Amount to increase the size by
    public float maxSize = 5f; // Optional: Maximum size limit for the paddle

    // Start is called before the first frame update
    void Start()
    {
        yPos = transform.position.y; // Initialize yPos
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(downKey) && yPos > bottomWall)
        {
            yPos -= paddleSpeed;
        }

        if (Input.GetKey(upKey) && yPos < topWall)
        {
            yPos += paddleSpeed;
        }

        transform.localPosition = new Vector3(transform.position.x, yPos, 0);
    }

    // Detect collisions with the ball
    void OnCollisionEnter2D(Collision2D other)
    {
        // Check if the object colliding is the ball
        if (other.gameObject.CompareTag("Ball"))
        {
            IncreasePaddleSize();
        }
    }

    // Method to increase the paddle size
    void IncreasePaddleSize()
    {
        // Increase the paddle's size but limit it
        float newSize = Mathf.Min(transform.localScale.y + sizeIncreaseAmount, maxSize);
        transform.localScale = new Vector3(transform.localScale.x, newSize, transform.localScale.z);
    }
}
