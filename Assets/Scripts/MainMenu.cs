using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string PauseScreen;
   

    public void StartGame()
    {
        SceneManager.LoadScene(PauseScreen);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    
}
