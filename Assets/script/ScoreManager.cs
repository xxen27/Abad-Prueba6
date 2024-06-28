using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    private int score = 0;
    public TextMeshProUGUI scoreText;
    private GameObject scoreObject; // Declaración de la variable

    void Start()
    {
        // Busca el objeto de puntuación por su nombre (asegúrate de que el nombre sea correcto)
        scoreObject = GameObject.Find("ScoreManager");
        UpdateScoreText();
    }

    public void AddScore(int value)
    {
        score += value;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}