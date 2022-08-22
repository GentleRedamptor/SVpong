using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    [SerializeField] float fallSpeed = 1;
    void Start()
    {
        
    }

    void Update()
    {
     transform.Translate(Vector3.down * fallSpeed);   

     if (transform.position.y < -10)
     {
        Destroy(gameObject);
     }
    }
}
