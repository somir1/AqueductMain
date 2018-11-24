using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class WaterSpeed : MonoBehaviour {

	
	void Start () {

        if (SceneManager.GetActiveScene().name == "Level1")
        {
            Debug.Log("datmass");
           GetComponent<Rigidbody2D>().gravityScale = 0.08f;
            //GetComponent<Rigidbody2D>().mass = 100.0f;

        }
        else if (SceneManager.GetActiveScene().name == "Level2")
        {
            Debug.Log("datmass2");
             GetComponent<Rigidbody2D>().gravityScale = 0.12f;
            //GetComponent<Rigidbody2D>().mass = 1.5f;

        }
        else if (SceneManager.GetActiveScene().name == "Level3")
        {
            Debug.Log("datmass3");
            GetComponent<Rigidbody2D>().gravityScale = 0.16f;
            //GetComponent<Rigidbody2D>().mass = 2.0f;
        }

    }
	
	
	void Update () {
		
	}
}
