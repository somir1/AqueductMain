using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WellManager : MonoBehaviour {

    public GameObject Panel;
    public GameObject[] Wells;
    public bool[] fulls;
    int numWater = 0 ;
    int count=0;
   
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

            if (numWater == 13)
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

                Panel.SetActive(true);

                

                // Panel.GetComponent<Stars>().show0.SetActive(true);
                //    Panel.GetComponent<Stars>().show1.SetActive(true);

                for (int i = 0; i < 3; i++) {

                    if (fulls[i] == true){
                        count++;
                    } 
                }

                if (count == 1)
                {
                    Panel.GetComponent<Stars>().show0.SetActive(true);
                }

                if (count == 2)
                {
                    Panel.GetComponent<Stars>().show0.SetActive(true);
                    Panel.GetComponent<Stars>().show1.SetActive(true);
                }

                if (count == 3)
                {
                    Panel.GetComponent<Stars>().show0.SetActive(true);
                    Panel.GetComponent<Stars>().show1.SetActive(true);
                    Panel.GetComponent<Stars>().show2.SetActive(true);
                }

                



            }


            
        }
    }

 
}
