using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreCanvas : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private float currentScore = 0;

    public void UpdateScore(float score)
    {
        currentScore += score;
        scoreText.text = currentScore.ToString();
    }
}
