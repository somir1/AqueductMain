using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aqueduct : MonoBehaviour {

    int count = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Ground")
        {
            if (count == 0) {
                //coll.gameObject.GetComponent<Collider2D>().enabled = false;
            }

            count++;
        }
    }
}
