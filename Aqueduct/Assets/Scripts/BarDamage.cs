using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarDamage : MonoBehaviour {

    public Image bar;
    float startfill = 0f;
	// Use this for initialization
	void Start () {
        bar.fillAmount = startfill;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.gameObject.tag == "Water")
        {
            bar.fillAmount += .2f;
        }
    }
}
