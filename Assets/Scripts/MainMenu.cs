using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Management;

public class MainMenu : MonoBehaviour
{
    //ManualXRControl man = new ManualXRControl();

    //void Start()
    //{
    //    man.StartXR();
    //}

    public void PlayExercise()
    {
        //XRGeneralSettings.Instance.Manager.InitializeLoader();
        //XRGeneralSettings.Instance.Manager.StartSubsystems();

        SceneManager.LoadScene("HelloCardboard"); // Loads the first exercise
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
