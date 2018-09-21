using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeKity : MonoBehaviour {
    public Collider col;
    public GameObject[] kitis;
    bool findkity = false;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public bool OnTriggerStay(Collider other)
    {
        foreach (var item in kitis)
        {
            if (col.gameObject.name == item.name)
            {
                findkity = true;
            }
            else
            {
                findkity = false;
            }
        }
        return findkity;
    }
}
