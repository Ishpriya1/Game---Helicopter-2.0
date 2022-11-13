using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public float speed;
    private float dist;

    public GameObject pipe;

    public static Move Pipe;

    void Start()
    {
        Pipe = this;
    }

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        dist = speed * Time.deltaTime;
        //Debug.Log(dist);
    }
}
