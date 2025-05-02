using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Use TextMeshProUGUI for better text rendering
    public static int score = 0;

    void Start()
    {
        score = 0;
        UpdateScoreText();
    }

    public void Update()
    {
        // Update the score text when the score changes
        UpdateScoreText();
    }

    public void UpdateScoreText()
    {
        scoreText.text =score.ToString();
    }
}