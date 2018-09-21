using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeowEvent : MonoBehaviour {
    public AudioClip meo;
    private AudioSource source;

    void Awake()
    {
        source = GetComponent<AudioSource>();
    }
    // Use this for initialization
    void Start () {

		
	}
    public void Meow()
    {
        if (!source.isPlaying)
        {
            source.PlayOneShot(meo);

        }
        //if(transform.FindChild("Sphere"))

    }
   

    // Update is called once per frame
    void Update () {
        if (Input.GetKey(KeyCode.Space) && !source.isPlaying){
            Meow();
        }
	}
}
