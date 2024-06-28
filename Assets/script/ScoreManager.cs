using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    private int score = 0;
    public TextMeshProUGUI scoreText;
    private GameObject scoreObject; // Declaraci�n de la variable

    void Start()
    {
        // Busca el objeto de puntuaci�n por su nombre (aseg�rate de que el nombre sea correcto)
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