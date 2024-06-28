using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColorChanger : MonoBehaviour
{
    public Material targetMaterial; // El material del objeto que deseas cambiar de color
    private Color selectedColor; // Variable para almacenar el color seleccionado

    public void SetSelectedColor(Color color)
    {
        selectedColor = color;
    }

    public void ChangeColor()
    {
        // Asigna el color seleccionado al material
        targetMaterial.color = selectedColor;
    }

    public void LoadNextScene()
    {
        // Carga la siguiente escena (asegúrate de que esté en la build settings)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

