using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectButton : MonoBehaviour
{
    public string PauseScreen;
    public string MainGame;
    public string SkinSelect;


    // Start is called before the first frame update
   void Start()
    {
     
    }

    public void LoadPauseScene()
    {
        SceneManager.LoadScene(PauseScreen);
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(MainGame);
    }

    public void LoadSkinSelect()
    {
        SceneManager.LoadScene(SkinSelect);
    }
}
