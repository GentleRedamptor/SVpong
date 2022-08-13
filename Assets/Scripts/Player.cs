using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]float charSpeed = 8;    
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
    }
    
}
