﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Reload ()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }

    public void LoadMainMenu ()
    {
        SceneManager.LoadScene(sceneBuildIndex: 0);
    }
}
