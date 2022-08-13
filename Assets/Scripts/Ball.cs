using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D ballRigidbody;
    [SerializeField] float ballSpeed = 1;
    void Start()
    {
        ballRigidbody = GetComponent<Rigidbody2D>();
        ballRigidbody.AddForce(Vector2.down * ballSpeed);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
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
    
}
