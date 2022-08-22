using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject[] livesSprites;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void ReduceHealth(int playerHP)
    {
        Destroy(livesSprites[playerHP]); 
    }
}
