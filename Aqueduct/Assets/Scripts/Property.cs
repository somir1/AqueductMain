using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Property : MonoBehaviour {

    public GameObject manager;
    int Hits =  0;

	// Use this for initialization
	void Start () {

  
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Water")
        { 
            Hits++;

            if (Hits == 5) {
                GetComponent<PolygonCollider2D>().isTrigger = true;
                GetComponent<SpriteRenderer>().color = new Color(0,0,0);
                manager.GetComponent<VillagePropertyManager>().numItemsLost ++;
            }
        }
    }

}
