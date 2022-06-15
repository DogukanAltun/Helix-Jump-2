using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    private int score;
    [SerializeField] private Text scoreText;
    void Start()
    {
        
    }
    public void GameScore(int ring)
    {
        score += ring;
        scoreText.text = "Score: " + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
