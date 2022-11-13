using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class PlayerScript : MonoBehaviour
{
    public Text currentScore;
    public Text highScore;
    public int score;
    //int highscore;
    private SpriteRenderer spriteRenderer;
    public GameObject gameOverCanvas;

    

    public GameManager manager;
    float timer;
    float maxTime;

    public static PlayerScript player;

    public GameObject Interstitial;
    public int timesPlayed;

    //AudioSource loseSound;

    public int countdownImage;

   


    private void Awake()
    {
        player = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        //playerpref.haskey()
        score = 0;
        maxTime = 0.1f;
        //highscore = PlayerPrefs.GetInt("HighScore", 0);
        Time.timeScale = 1;
        highScore.text = "Highscore:  " + PlayerPrefs.GetInt("Highscore", 0).ToString("0");
        //Debug.Log(highScore);
        //PlayerPrefs.SetInt("Played", 0);

        //loseSound = GetComponent<AudioSource>();

    }
    
    void Update()
    {
        /*score++;
        currentScore.text = score.ToString();

        if(score > highscore)
        {
            //Debug.Log("yes");
            PlayerPrefs.SetInt("HighScore", score);
            PlayerPrefs.Save();
            highScore.text = PlayerPrefs.GetInt("HighScore").ToString();
            //Debug.Log(highScore);
        }*/
        
        timer += Time.deltaTime;
        if (timer >= maxTime)
        {
            score++;
            currentScore.text = score.ToString();
            timer = 0;

            if (score % 100 == 0)
            {

                Time.timeScale += 0.01f;
            }
        }

        if (Time.timeScale == 0)
        {
            if (score > PlayerPrefs.GetInt("Highscore", 0))
            {
                PlayerPrefs.SetInt("Highscore", score);
                highScore.text = "Highscore:  " + PlayerPrefs.GetInt("Highscore", 0).ToString("0");
            }
        }
    }


    public void GameOver()
    {
        Debug.Log("I have entered Game over");
        //loseSound.Play();

        //HelicopterMove.helicopter.GetComponent<ParticleSystem>().SetActive(true);
        HelicopterMove.helicopter.Player.transform.GetChild(0).gameObject.SetActive(true);       
        //HelicopterMove.helicopter.gameObject.SetActive(false);

        //Move.Pipe.gameObject.SetActive(false);


        //Debug.Log("yes");
        //Debug.Log("1.timeplayed" + timesPlayed);



        timesPlayed = PlayerPrefs.GetInt("Played", 0);
        timesPlayed++;
        PlayerPrefs.SetInt("Played", timesPlayed);
        Debug.Log("Time Played: " + timesPlayed);
        gameOverCanvas.SetActive(true);

        StartCoroutine(Wait());

        
        //RepeatBg.repeatBg.rb1.velocity = Vector3.zero;


        //PlayerPrefs.SetInt("Score", score);
        if (score > PlayerPrefs.GetInt("Highscore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);
            //PlayerPrefs.Save();
            highScore.text = PlayerPrefs.GetInt("HighScore").ToString();
        }

        if (PlayerPrefs.GetInt("Played") % 5 == 0)
        {
            Debug.Log("Played" + PlayerPrefs.GetInt("Played"));
            InterstitialAds.interstitial.ShowInterstitial();
            //Interstitial.GetComponent<InterstitialAds>().ShowInterstitial();
            PlayerPrefs.SetInt("Played", 0);
        }

    }

    System.Collections.IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.2f);
        Time.timeScale = 0;
        //Interstitial.GetComponent<InterstitialAds>().ShowInterstitial();
    }

    








}





