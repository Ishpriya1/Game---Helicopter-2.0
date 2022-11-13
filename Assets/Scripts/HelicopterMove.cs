using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterMove : MonoBehaviour
{
    public float velocity = 1;
    public Rigidbody2D rb;

    public static HelicopterMove helicopter;

    public GameObject Player;

    //public GameObject PlayerWithExplosion;


    //public new GameObject particleSystem;

    public Vector3 originalPos;

    public Vector3 originalPos2;


    public bool gameOver = false;


    public AudioSource helicopterSound;

    //public ParticleSystem system;

    void Start()
    {
        helicopter = this;
        rb = GetComponent<Rigidbody2D>();
        //Player.transform.GetChild(0).gameObject.SetActive(false);

        helicopterSound = GetComponent<AudioSource>();
        Reposition();
        //system = Player.transform.GetChild(0).gameObject.GetComponent<ParticleSystem>();
        
    }
    public void Reposition()
    {
        originalPos = new Vector3(0, 0, 0);
        Player.transform.position = originalPos;
        //PlayerWithExplosion.transform.position = originalPos2;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * velocity;
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //PlayerPrefs.SetInt("Played", timesPlayed);
        //Debug.Log("Hello 2");
        helicopterSound.Stop();
        
        //Debug.Log("Hello");
        PlayerScript.player.GameOver();

        //AudioListener.pause = true;
        PipeSpawner.pipeSpawner.gameObject.SetActive(false);
        Player.transform.GetChild(0).gameObject.SetActive(true);
        /*if (Player.transform.GetChild(0).gameObject)
        {
            Debug.Log("I will explode now");
            Instantiate(Player.transform.GetChild(0).gameObject, transform.position, transform.rotation);
        }*/


        //Player.SetActive(false);
        //Destroy(gameObject);

    }

    /*private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("star"))
        {
            Destroy(other.gameObject);
        }
    }*/
}
