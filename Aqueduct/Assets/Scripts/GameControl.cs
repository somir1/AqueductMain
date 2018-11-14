using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour {

    public static GameControl control;

    public int currentLevel = 0;
    int[] levels;

    public GameObject[] button1;
    public GameObject[] button2;
    public GameObject[] button3;

    public Button b2;
    public Button b3;

    public int level1;
    public int level2;
    public int level3;
    public string lastLevel;

    void Awake()
    {
        if (control == null) {
            DontDestroyOnLoad(gameObject);
            control = this;
        } else if (control != this) {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Menu"){

            button2 = GameObject.FindGameObjectsWithTag("Button2");
            button3 = GameObject.FindGameObjectsWithTag("Button3");


            foreach (GameObject con in button2)
            {
                b2 = con.GetComponent<Button>();

            }


            foreach (GameObject con in button3)
            {
                b3 = con.GetComponent<Button>();
            }

            if (currentLevel == 1) {
                b2.interactable = !b2.interactable;

            }

            if (currentLevel == 0) {
                b2.interactable = !b2.interactable;
                b3.interactable = !b3.interactable;

            }
        }

    }

   

    public void Save() {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Open(Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);

        PlayerData data = new PlayerData();

        data.level1 = level1;
        data.level2 = level2;
        data.level3 = level3;
    }
}

[Serializable]
class PlayerData {
    public int level1;
    public int level2;
    public int level3;
}
