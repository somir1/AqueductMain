using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour {

	public void RestartCurrentLevel()
    {
        Debug.Log("Scene Reloaded");
        SceneManager.LoadScene("LiquidScene");
    }
}
