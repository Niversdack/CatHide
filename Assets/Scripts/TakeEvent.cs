using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TakeEvent : MonoBehaviour {
    public GameObject text;
    string last;
    int score;
    int gos;

    // Use this for initialization
    void Start () {
        
        score = 0;
        text.GetComponent<Text>().text ="Score:"+ score.ToString();
        
        gos = GameObject.FindGameObjectsWithTag("Kity").Length;
        Debug.Log(gos);
    }
	
	// Update is called once per frame
	void Update () {
       
    }
   
    private void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.tag == "Kity")
        {
            Destroy(col.gameObject);
            score = score + 1;

            last = "Score:" + score;
            text.GetComponent<Text>().text = last;
            if (gos == score)
            {
                //переход на следующую сцену
            }
        }
    }
}
