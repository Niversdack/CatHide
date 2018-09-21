using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigerCat : MonoBehaviour {
    public GameObject go;
    public GameObject[] kitis;
    // Use this for initialization
    void OnTriggerEnter(Collider col)

    {
        foreach (var item in kitis)
        {
            if (col.gameObject.name == item.name)
            {
                go.GetComponent<MeowEvent>().Meow();
            }
        }

    }
}
