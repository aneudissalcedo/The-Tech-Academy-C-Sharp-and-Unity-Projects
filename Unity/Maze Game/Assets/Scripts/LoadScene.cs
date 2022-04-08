using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void LoadNextScene()
    {
        SceneManager.LoadScene("Main");
        Debug.Log("Loading main scene...");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting the game...");
    }
}
