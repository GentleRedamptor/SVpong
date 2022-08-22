using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject ball;
    Player player;
    Transform ballStartPosition;
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        ballStartPosition = ball.transform;
    }

    public void BallHasFallen()
    {
        player.ReduceHealth();
        Instantiate(ball, ballStartPosition);
    }
    
}
