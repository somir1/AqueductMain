using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarDamage : MonoBehaviour {

    //references the health bar
    public Image bar;
    //variable that sets the amount of fill you start with
    float startfill = 0f;
    Collider2D wellcollider;
    public Transform waterSpawn;
    public bool full = false;
    
	// Use this for initialization

	void Start () {
        //sets barfill to 0
        bar.fillAmount = startfill;
        wellcollider = GetComponent<Collider2D>(); 
	}
	
	// Update is called once per frame
	void Update () {
     
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag == "Water")
        {
            bar.fillAmount += .2f;

            if (full == false) {
                Destroy(coll.gameObject);
            }
           

            if (bar.fillAmount == 1f)
            {
                full = true;
                
            }
        }

        if (full == true) {

            if (gameObject.tag == "Left")
            {

                coll.transform.position = waterSpawn.position;
                coll.rigidbody.velocity = new Vector3(-0.2f, 0, 0);
            }

            if (gameObject.tag == "Right")
            {
                coll.transform.position = waterSpawn.position;
                coll.rigidbody.velocity = new Vector3(0.2f, 0, 0);
            }
        }
       


    }
}
