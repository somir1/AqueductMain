using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour {

    public GameObject[] Control;
    string lastLevel;
    
    private void Start()
    {

        //Debug.Log(lastLevel);
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ReloadLevel ()
    {
        Control = GameObject.FindGameObjectsWithTag("GameControl");
        foreach (GameObject con in Control)
        {
            lastLevel = con.GetComponent<GameControl>().lastLevel;
        }
        SceneManager.LoadScene(lastLevel);

    }


}
