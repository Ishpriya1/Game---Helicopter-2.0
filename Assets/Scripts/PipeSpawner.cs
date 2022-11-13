using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject pipe;
    //public GameObject star;
   // private float stoneheight;
    //private float starheight;
    //private float boundaryheight1;
    //private float boundaryheight2;
    private float height;
    GameObject newpipe;
    //GameObject newstar;
    private Camera cam;
    //public GameObject boundary1;
    //public GameObject boundary2;

    public static PipeSpawner pipeSpawner;

    void Start()
    {

        pipeSpawner = this;

        //boundaryheight1 = boundary1.transform.GetComponent<SpriteRenderer>().sprite.bounds.size.y;
        //boundaryheight2 = boundary2.transform.GetComponent<SpriteRenderer>().sprite.bounds.size.y;
        //Debug.Log("Boundary" + boundaryheight);
        cam = Camera.main;
        Vector3 point = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height, cam.nearClipPlane));
        height = point.y;
        Debug.Log("World Height " + height);
        newpipe = Instantiate(pipe);
        newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-0.5f, 3.5f), 0);
        //stoneheight = newpipe.transform.GetComponent<SpriteRenderer>().sprite.bounds.size.y;
        /*RectTransform rt = (RectTransform)newpipe.transform;
        stoneheight = rt.rect.height;
        Debug.Log(stoneheight + "stoneheight2");*/
        //newstar = Instantiate(star);
        //newstar.transform.position = transform.position + new Vector3(0, Random.Range(-height + boundaryheight, height - boundaryheight), 0);
        //starheight = newstar.transform.GetComponent<SpriteRenderer>().sprite.bounds.size.y;
    }

   
    void Update()
    {
        //Debug.Log("Boundary 1:" + boundaryheight1);
        //Debug.Log("Boundary 2:" + boundaryheight2);
        if (timer > maxTime)
        { 
            newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(7, Random.Range(-0.5f, 3.5f), 0);
            Debug.Log("Stone y position " + newpipe.transform.position.y);
            //newstar = Instantiate(star);
           /* if (newpipe.transform.position.y < 0)
            {
                newstar.transform.position = transform.position + new Vector3(7, Random.Range(newpipe.transform.position.y + starheight + boundaryheight, height - starheight - boundaryheight), 0);
            }
            else
            {
                newstar.transform.position = transform.position + new Vector3(7, Random.Range(-height + starheight + boundaryheight, newpipe.transform.position.y - starheight - boundaryheight), 0);
            }*/

            Destroy(newpipe, 10);
            timer = 0;
            maxTime += Time.deltaTime;
        }

        timer += Time.deltaTime;
    }
}
