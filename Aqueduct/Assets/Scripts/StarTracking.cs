using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarTracking : MonoBehaviour {

    public int StarCount;
    public int WellCount;
    // Use this for initialization
    void Start () {
        StarCount = 0; 


    }
	
	// Update is called once per frame
	void Update () {


    }
    /*
     * Need to add variable that contains reference to the obstacle object being collected.
     * if the object is collected star count ++
     * create sprites for stars, connect star count to UI and then print out how many stars you collected.
    public void WellsCollected()
    {
        if ( WellCount ==  )
        {
            StarCount++;
        }

    }
    */
}
