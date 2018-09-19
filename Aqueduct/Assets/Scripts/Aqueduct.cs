using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aqueduct : MonoBehaviour
{

    int count = 0;

   



    public Transform waterSpawn;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Left(GameObject gameObject)
    {
        Debug.Log("Left");

    }

  

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Water")
        {

            count++;


            if (gameObject.name == "Left(Clone)")
            {

                coll.transform.position = waterSpawn.position;
                coll.rigidbody.velocity = new Vector3(-1, 0, 0);
            }

                if (gameObject.name == "Right(Clone)")
            {
                coll.transform.position = waterSpawn.position;
                coll.rigidbody.velocity = new Vector3(1, 0, 0);
            }


            if (gameObject.name == "Horizontal(Clone)")
            {

            }


            if (gameObject.name == "Vertical(Clone)")
            {
                coll.transform.position = waterSpawn.position;
                coll.rigidbody.velocity = new Vector3(0, 0, 0);
            }


        }
    }
}
