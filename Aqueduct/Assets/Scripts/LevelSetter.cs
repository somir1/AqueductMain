using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSetter : MonoBehaviour {

    public GameObject[] Control;

    // Use this for initialization
    void Start () {

        Control = GameObject.FindGameObjectsWithTag("GameControl");

        foreach (GameObject con in Control)
        {
            con.GetComponent<GameControl>().SetLevels();
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
