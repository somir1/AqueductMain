using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour {

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ReloadLevel ()
    {
        SceneManager.LoadScene("LiquidScene");
    }
    

}
