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

    void Left(GameObject gameObject) {
        Debug.Log("Left");

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Water")
        {
           

            if (gameObject.name == "Left(Clone)") {
                
                //Rigidbody2D m_Rigidbody = gameObject.GetComponent<Rigidbody2D>(); 
                Left(coll.gameObject);
               // Physics.IgnoreLayerCollision(8, 9);
            }


            if (gameObject.name == "Right(Clone)")
            {
                Debug.Log("Right");
            }


            if (gameObject.name == "Horizontal(Clone)")
            {
                Debug.Log("Horizontal");
            }


            if (gameObject.name == "Vertical(Clone)")
            {
                Debug.Log("Vertical");
                Rigidbody2D m_Rigidbody = gameObject.GetComponent<Rigidbody2D>();
                
                //gameObject.transform.position = new Vector3(transform.position.x, transform.position.y, 0);

            }


        }
    }
}
