using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D ballRigidbody;
    [SerializeField] float ballSpeed = 1;
    [SerializeField] GameObject powerup;
    GameManager gameManager;
    [SerializeField] GameObject ball;
    void Start()
    {
        ballRigidbody = GetComponent<Rigidbody2D>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        StartCoroutine(SpawnMovingWait());
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        ballRigidbody.AddTorque(50 , ForceMode2D.Force);
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Hit the player");
        }   
        if (other.gameObject.tag == "Breakable")
        {
            GameObject block = other.gameObject;
            Debug.Log("BONK here is a block");
            int chance = Random.Range(1,10);
            if (chance == 1)
            {
                Instantiate(powerup, block.transform.position, block.transform.rotation);
            }
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

    public void SpawnOtherBall()
    {
        Instantiate(ball, transform.position, Random.rotation);
    }

    
}
