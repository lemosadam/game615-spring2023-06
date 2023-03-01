using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour

{
    int score = 0;
    int enemyscore = 0;
    public TMP_Text scoreText;
    public TMP_Text enemyText;
    public PlayerController player;
    public TMP_Text winText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncrementScore()
    {
        score = score + 1;
        scoreText.text = score.ToString();

        if ( score == 3)
        {
            winText.text = "You Win!";
            
        }
        Debug.Log("score+1");

    }

    public void IncrementEnemy()
    {
        enemyscore = enemyscore + 1;
        enemyText.text = enemyscore.ToString();
        Debug.Log("score+1");
    }
}
