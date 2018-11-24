using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSetter : MonoBehaviour {

    public GameObject[] Control;

    // Use this for initialization
    void Start () {
        Debug.Log("BOI");
        Control = GameObject.FindGameObjectsWithTag("GameControl");

       
        Control[0].GetComponent<GameControl>().SetLevels();
          
        

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
