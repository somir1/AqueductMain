using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WellManager : MonoBehaviour {

    public GameObject[] Wells;
    public bool[] fulls;
    int numWater = 0 ;
   
    // Use this for initialization
    void Start () {

        for (int i = 0; i < fulls.Length; i++) {
            fulls[i] = false;
        }
	}
	
	// Update is called once per frame
	void Update () {

     

       
	}

    void OnTriggerEnter2D(Collider2D other)
    {
       if (other.gameObject.tag == "Water") {
            numWater++;

            if (numWater == 1)
            {
                for (int i = 0; i < Wells.Length; i++)
                {
                    if (Wells[i].GetComponent<BarDamage>().full == true)
                    {
                        fulls[i] = true;

                    }
                }
                for (int j = 0; j < 3; j++) {
                    Debug.Log(fulls[j]);
                }
            }
            
        }
    }

 
}
