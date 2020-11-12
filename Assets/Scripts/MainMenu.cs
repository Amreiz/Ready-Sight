using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayExercise()
    {
        SceneManager.LoadScene("Exercise_01"); // Loads the first exercise
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
