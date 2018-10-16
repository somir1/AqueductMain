using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void TaptoStart()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }

    public void PlayLevel1 ()
    {
        SceneManager.LoadScene(sceneBuildIndex: 2);
    }

    public void PlayLevel2 ()
    {
        SceneManager.LoadScene(sceneBuildIndex: 3);
    }

    public void PlayLevel3 ()
    {
        SceneManager.LoadScene(sceneBuildIndex: 4);
    }

    public void Info ()
    {
        SceneManager.LoadScene(sceneBuildIndex: 7);
    }

    public void Reload ()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }

    public void LoadMainMenu ()
    {
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame ()
    {
        Debug.Log("Quitting...");
        Application.Quit();
    }
}
