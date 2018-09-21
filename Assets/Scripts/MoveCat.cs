using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCat : MonoBehaviour {

    public GameObject player;
    public GameObject Triger;

    public int speedRotation = 3;
    public int speed = 5;
    Animator anim;
    int jumpHash = Animator.StringToHash("Jump");
    int runStateHash = Animator.StringToHash("Base Layer.Run");
    public int jumpSpeed = 50;
    float horizontalSpeed = 2.0f;
    float verticalSpeed = 2.0f;
    public Collider triger;
    int Scorekity = 0;

    void Start()
    {
        player = (GameObject)this.gameObject;
        //animator.AddClip(anima, "animCube");
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        
        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        //float v = verticalSpeed * Input.GetAxis("Mouse Y");
        
        transform.Rotate(0, h, 0);


        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            player.transform.position += player.transform.forward * speed * Time.deltaTime;
            anim.SetFloat("Speed",speed);

        }else { anim.SetFloat("Speed", -1); }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            player.transform.position -= player.transform.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            player.transform.position -= player.transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            player.transform.position += player.transform.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.E))
        {
            Take();
        }

    }
    
    private void Take()
    {
        if (!Triger.GetComponent<TakeKity>().OnTriggerStay(triger))
        {
            ++Scorekity;
        }
    }
}