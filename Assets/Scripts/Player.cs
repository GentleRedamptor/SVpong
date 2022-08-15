using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]float charSpeed = 8;
    [SerializeField] int playerHealth = 3;
    void Start()
    {
        
    }

    void Update()
    {
        Movement();
    }
    
    void Movement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 position = new Vector3(horizontalInput, 0, 0);
        transform.Translate(position * charSpeed * Time.deltaTime);
        if (transform.position.x <= -7.5f)
        {
            transform.position = new Vector2 (-7.5f , transform.position.y);
        }
        if (transform.position.x >= 7.6)
        {
            transform.position = new Vector2(7.6f, transform.position.y);
        }
    }

    public void ReduceHealth()
    {
        playerHealth--;
        if (playerHealth < 1)
        {
            Debug.Log("G a m e   O v e r !");
        }
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.name == "+1BallPup")
        {
            //create another ball in the ball's position
        }
        
    }    
}
