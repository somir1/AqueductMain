using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarDisplay : MonoBehaviour {

    public GameObject[] Control;
    public GameObject[] Panels;

    public int level1 = 0;
    public int level2 = 0;
    public int level3 = 0;

    // Use this for initialization
    void Start () {
        Control = GameObject.FindGameObjectsWithTag("GameControl");

        
    }
	
	// Update is called once per frame
	void Update () {
        foreach (GameObject con in Control)
        {
            if (con != null) {
                level1 = con.GetComponent<GameControl>().level1;
                level2 = con.GetComponent<GameControl>().level2;
                level3 = con.GetComponent<GameControl>().level3;

            }

        }

        if (level1 == 1) {
            Panels[0].GetComponent<Stars>().show0.SetActive(true);
        }
        if (level1 == 2)
        {
            Panels[0].GetComponent<Stars>().show0.SetActive(true);
            Panels[0].GetComponent<Stars>().show1.SetActive(true);
        }
        if (level1 == 3)
        {
            Panels[0].GetComponent<Stars>().show0.SetActive(true);
            Panels[0].GetComponent<Stars>().show1.SetActive(true);
            Panels[0].GetComponent<Stars>().show2.SetActive(true);
        }

        if (level2 == 1)
        {
            Panels[1].GetComponent<Stars>().show0.SetActive(true);
        }
        if (level2 == 2)
        {
            Panels[1].GetComponent<Stars>().show0.SetActive(true);
            Panels[1].GetComponent<Stars>().show1.SetActive(true);
        }
        if (level2 == 3)
        {
            Panels[1].GetComponent<Stars>().show0.SetActive(true);
            Panels[1].GetComponent<Stars>().show1.SetActive(true);
            Panels[1].GetComponent<Stars>().show2.SetActive(true);
        }

        if (level3 == 1)
        {
            Panels[2].GetComponent<Stars>().show0.SetActive(true);
        }
        if (level3 == 2)
        {
            Panels[2].GetComponent<Stars>().show0.SetActive(true);
            Panels[2].GetComponent<Stars>().show1.SetActive(true);
        }
        if (level3 == 3)
        {
            Panels[2].GetComponent<Stars>().show0.SetActive(true);
            Panels[2].GetComponent<Stars>().show1.SetActive(true);
            Panels[2].GetComponent<Stars>().show2.SetActive(true);
        }

    }
}
