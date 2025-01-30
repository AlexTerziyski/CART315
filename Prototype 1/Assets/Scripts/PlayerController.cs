using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Creating an instance of ScoreManager class
    public ScoreManager scoreManager;
    private Rigidbody2D rigidbody;
    bool isGrounded = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void OnMouseDown()
    {
        if (isGrounded)
        {
            rigidbody.AddForce(Vector3.up * 300f);
            scoreManager.AddScore(10);
        }
        isGrounded = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
        else if (collision.gameObject.CompareTag("Obs"))
        {
            // Game Over!
            GameManager.instance.GameOver();
        }
    }
}
