using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeowEvent : MonoBehaviour
{
    public AudioClip[] meo;
    public AudioSource source;
    private System.Random rnd = new System.Random();
    void Awake()
    {


    }
    // Use this for initialization
    void Start()
    {


    }
    public void Meow()
    {


        int i = rnd.Next(0, meo.Length);

        if (!source.isPlaying)
        {
            source.PlayOneShot(meo[i]);

        }


        //if(transform.FindChild("Sphere"))

    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Meow();
        }
    }
}
