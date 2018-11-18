using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WellManager : MonoBehaviour {

    public GameObject[] Control;
   
    public GameObject Panel;
    public GameObject[] Wells;
    public bool[] fulls;
    int numWater = 0 ;
    int count=0;

   
    // Use this for initialization
    void Start () {

        Debug.Log(SceneManager.GetActiveScene().name);

        for (int i = 0; i < fulls.Length; i++) {
            fulls[i] = false;
        }

        Control = GameObject.FindGameObjectsWithTag("GameControl");
        foreach (GameObject con in Control)
        {
            con.GetComponent<GameControl>().lastLevel = SceneManager.GetActiveScene().name;
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

                    if (SceneManager.GetActiveScene().name == "Level1")
                    {

                        foreach (GameObject con in Control)
                        {
                            con.GetComponent<GameControl>().level1 = 1;
                        }

                    }

                    if (SceneManager.GetActiveScene().name == "Level2")
                    {

                        foreach (GameObject con in Control)
                        {
                            con.GetComponent<GameControl>().level2 = 1;
                        }

                    }

                    if (SceneManager.GetActiveScene().name == "Level3")
                    {

                        foreach (GameObject con in Control)
                        {
                            con.GetComponent<GameControl>().level3 = 1;
                        }

                    }
                }

                if (count == 2)
                {
                    Panel.GetComponent<Stars>().show0.SetActive(true);
                    Panel.GetComponent<Stars>().show1.SetActive(true);

                    if (SceneManager.GetActiveScene().name == "Level1")
                    {
                        foreach (GameObject con in Control)
                        {
                            con.GetComponent<GameControl>().level1 = 2;
                        }
                    }
                    if (SceneManager.GetActiveScene().name == "Level2")
                    {
                        foreach (GameObject con in Control)
                        {
                            con.GetComponent<GameControl>().level2 = 2;
                        }
                    }
                    if (SceneManager.GetActiveScene().name == "Level3")
                    {
                        foreach (GameObject con in Control)
                        {
                            con.GetComponent<GameControl>().level3 = 2;
                        }
                    }
                }

                if (count == 3)
                {
                    Panel.GetComponent<Stars>().show0.SetActive(true);
                    Panel.GetComponent<Stars>().show1.SetActive(true);
                    Panel.GetComponent<Stars>().show2.SetActive(true);

                    if (SceneManager.GetActiveScene().name == "Level1")
                    {
                        foreach (GameObject con in Control)
                        {
                            con.GetComponent<GameControl>().level1 = 3;
                            con.GetComponent<GameControl>().currentLevel = 1;
                        }
                    }
                    if (SceneManager.GetActiveScene().name == "Level2")
                    {
                        foreach (GameObject con in Control)
                        {
                            con.GetComponent<GameControl>().level2 = 3;
                            con.GetComponent<GameControl>().currentLevel = 2;
                        }
                    }
                    if (SceneManager.GetActiveScene().name == "Level3")
                    {
                        foreach (GameObject con in Control)
                        {
                            con.GetComponent<GameControl>().level3 = 3;
                            con.GetComponent<GameControl>().currentLevel = 3;
                        }
                    }
                }

                



            }


            
        }
    }

 
}
