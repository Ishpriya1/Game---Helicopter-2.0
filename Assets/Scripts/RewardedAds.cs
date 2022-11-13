using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class RewardedAds : MonoBehaviour, IUnityAdsListener, IUnityAdsLoadListener
{

#if UNITY_IOS
        string gameID = "4883727";


#elif UNITY_ANDROID
    string gameID = "4514205";
#endif

    public GameObject addButton;
    private int timesPlayed;
    public static RewardedAds rewardedAds;
    public bool TestMode;

    private string rewardedID = "RewardedAd_Android";

    // Start is called before the first frame update
    void Start()
    {
        rewardedAds = this;
        Advertisement.Initialize(gameID, TestMode);
        Advertisement.AddListener(this);
    }


    public void LoadAd()
    {
        //Debug.Log("Loaded Ad: " + gameID);
        Advertisement.Load(gameID, this);
        PlayRewardedAd();
        //BannerAds.bannerAds.HideBannerAd();
    }

    public void OnUnityAdsAdLoaded(string placementId)
    {
        //Debug.Log("Ads loaded");
        PlayRewardedAd();
        //BannerAds.bannerAds.HideBannerAd();
    }

    public void OnUnityAdsFailedToLoad(string placementId, UnityAdsLoadError error, string message)
    {
        //Debug.Log("Ads did not load");
    }

    public void PlayRewardedAd()
    {
        if (Advertisement.IsReady(rewardedID))
        {
            Advertisement.Show(rewardedID);
        }
        else
        {
           // Debug.Log("Rewarded ad is not ready");
        }
    }


    public void OnUnityAdsReady(string placementId)
    {
        //Debug.Log("Ads are ready");
    }

    public void OnUnityAdsDidError(string message)
    {
        Debug.Log("Error: " + message);
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        //Debug.Log("Video started");
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        if (placementId == "RewardedAd_Android" && showResult == ShowResult.Finished)
        {
            timesPlayed = PlayerPrefs.GetInt("AdsPlayed", 0);
            timesPlayed++;
            PlayerPrefs.SetInt("AdsPlayed", timesPlayed);

            if (PlayerPrefs.GetInt("AdsPlayed") == 5)
            {
                addButton.SetActive(false);
                PlayerPrefs.SetInt("AdsPlayed", 0);
            }
            Debug.Log("I have played the ad");
            PlayerScript.player.gameOverCanvas.SetActive(false);
            //HelicopterMove.helicopter.Player.transform.GetChild(0).gameObject.SetActive(true);
            HelicopterMove.helicopter.Player.SetActive(true);
            HelicopterMove.helicopter.Player.transform.GetChild(0).gameObject.SetActive(false);
            PipeSpawner.pipeSpawner.gameObject.SetActive(true);
            //FlyBird.flyBird.Player.transform.position = FlyBird.flyBird.originalPos;
            Time.timeScale = 1;

            HelicopterMove.helicopter.Reposition();

            /*if (Input.GetMouseButtonDown(0))
            {
                //HelicopterMove.helicopter.rb.velocity = Vector2.up * HelicopterMove.helicopter.velocity;

                
            }*/

        }
    }

    
}
