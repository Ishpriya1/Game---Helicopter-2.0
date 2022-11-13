using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class GameManager : MonoBehaviour
{
    //public GameObject startPanel, skinPanel;
    //public SpriteRenderer playerSkin;
    //public Sprite[] skinArray;
    public static GameManager Instance;

    //public Transform currentSkin;

    




    void Start()
    {
        //Initialization();
        Instance = this;
        //Debug.Log("deleted");
        //PlayerPrefs.DeleteAll();
    }

    /*public void Initialization()
    {
        playerSkin.sprite = skinArray[PlayerPrefs.GetInt("current_skin",0)];
        startPanel.SetActive(true);
        //PlayerPrefs.SetString("UnlockedSkins", "1");
        if (!PlayerPrefs.HasKey("UnlockedSkins"))
        {
            Debug.Log("New");
            PlayerPrefs.SetString("UnlockedSkins", " 1");

            skinPanel.SetActive(true);
            SkinUnlockManagement();
        }
    }*/

    /*private void SkinUnlockManagement()
    {
        string[] unlockedSkinArray = PlayerPrefs.GetString("UnlockedSkins").Split('.');
        var allSkins = skinPanel.transform;
        //Debug.Log("Skins " + allSkins);
        //Debug.Log("CHILD " + allSkins.childCount);
        for (var i = 2; i < allSkins.childCount; i++)
        {
            //Debug.Log(allSkins.GetChild(i));
            currentSkin = allSkins.GetChild(i);
            Debug.Log("Current Skin " + currentSkin);
            Debug.Log("Skin Index " + currentSkin.GetComponent<Skin>().skinIndex.ToString());
            var skinIndex = currentSkin.GetComponent<Skin>().skinIndex.ToString();
            foreach (string val in unlockedSkinArray)
            {
                Debug.Log("Value " + val);
            }
            if (Array.IndexOf(unlockedSkinArray, skinIndex) >= 0)
            {
                Debug.Log("Hi Urvashi");
                Debug.Log("Child 1 " + currentSkin.transform.GetChild(1).gameObject);
                currentSkin.transform.GetChild(1).gameObject.SetActive(false);
            }

            skinPanel.SetActive(false);
        }
    }*/

    public void OpenSkinPanel()
    {
        //skinPanel.SetActive(true);
    }

    public void CloseSkinPanel()
    {
       // skinPanel.SetActive(false);
        
    }

    public void StartGame()
    {
       // startPanel.SetActive(false);
    }

    /*public void SetSkin(int skinIndex)
    {
        playerSkin.sprite = GameManager.Instance.skinArray[skinIndex];
        PlayerPrefs.SetInt("current_skin", skinIndex);
    }*/

    public void ReplayLevelA()
    {
        //int currskinIndex = PlayerPrefs.GetInt("current_skin");
        //Debug.Log("currskinIndex : " + currskinIndex);
        SceneManager.LoadScene("PauseScreen");
        
        //playerSkin.sprite = GameManager.Instance.skinArray[currskinIndex];
        //SetSkin(currskinIndex);
    }
  
}

