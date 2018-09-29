using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PlayLevel1 ()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }

    public void PlayLevel2 ()
    {
        SceneManager.LoadScene(sceneBuildIndex: 2);
    }

    public void PlayLevel3 ()
    {
        SceneManager.LoadScene(sceneBuildIndex: 3);
    }

    public void Info ()
    {
        SceneManager.LoadScene(sceneBuildIndex: 6);
    }

    public void Reload ()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }

    public void LoadMainMenu ()
    {
        SceneManager.LoadScene(sceneBuildIndex: 0);
    }

    public void QuitGame ()
    {
        Debug.Log("Quitting...");
        Application.Quit();
    }
}
