using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Management;

public class MainMenu : MonoBehaviour
{
    public void PlayExercise()
    {
        SceneManager.LoadScene("HelloCardboard"); // Loads the first exercise
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
