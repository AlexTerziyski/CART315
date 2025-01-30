using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
  public TextMeshProUGUI scoreText;
  public int score = 0;

  public void AddScore(int value)
  {
    score += value;
    scoreText.text = score.ToString();
  }
}
