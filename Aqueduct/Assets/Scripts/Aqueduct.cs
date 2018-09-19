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
            // Destroy(coll.gameObject);

            if (gameObject.name == "L")
            {

                coll.transform.position = waterSpawn.position;
            }


            if (gameObject.name == "R(Clone)")
            {
                coll.transform.position = waterSpawn.position;
            }


            if (gameObject.name == "Hori(Clone)")
            {

            }


            if (gameObject.name == "Ver(Clone)")
            {
                coll.transform.position = waterSpawn.position;
            }


        }
    }
}
