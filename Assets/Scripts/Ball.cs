using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D ballRigidbody;
    [SerializeField] float ballSpeed = 1;
    GameManager gameManager;
    void Start()
    {
        ballRigidbody = GetComponent<Rigidbody2D>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        StartCoroutine(SpawnMovingWait());
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        ballRigidbody.AddTorque(50 , ForceMode2D.Force);
        if (other.gameObject.name == "Player")
        {
            Debug.Log("Hit the player");
        }   
        if (other.gameObject.name == "Block")
        {
            Debug.Log("BONK here is a block");
            GameObject block = other.gameObject;
            Destroy(block);
        } 
    }
    IEnumerator SpawnMovingWait()
    {
        yield return new WaitForSeconds(3);
        ballRigidbody.AddForce(Vector2.down * ballSpeed);
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Wall")
        {
            gameManager.BallHasFallen();
            BallFallen();
        }
        
    }

    void BallFallen()
    {
        Destroy(gameObject);
    }

    
}
