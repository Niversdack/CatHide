using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;
public class TakeEvent : MonoBehaviour {
    public GameObject text;
    string last;
    int score;
    int gos;

    void Start () {
        
        score = 0;
        text.GetComponent<Text>().text ="Score:"+ score.ToString();
        
        gos = GameObject.FindGameObjectsWithTag("Kity").Length;
        Debug.Log(gos);
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
                SceneManager.LoadScene(1);
            }
        }
    }
}
