using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCat : MonoBehaviour
{

    public GameObject player;
    public float speedRotation = 150.0f;
    public int speed = 3;
    Animator anim;
    int jumpHash = Animator.StringToHash("Jump");
    int runStateHash = Animator.StringToHash("Base Layer.Run");
    //public int jumpSpeed = 50;
    void Start()
    {
        player = (GameObject)this.gameObject;
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * speedRotation;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetFloat("Speed", speed);
        }
        else { anim.SetFloat("Speed", -1); }

    }
}