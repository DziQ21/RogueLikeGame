using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuButtons : MonoBehaviour
{
   public void playGame()
    {
        SceneManager.LoadScene(1);
    }
    public void quitGame()
    {
        Debug.Log("Exited from the game");
        Application.Quit();
    }
    public void openControls()
    {
        SceneManager.LoadScene(2);
    }
    public void openMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void menuRestart()
    {
        SceneManager.LoadScene(1);
    }
    public void openControlsPause()
    {
        SceneManager.LoadScene(4);
    }
    public void openPause()
    {
        SceneManager.LoadScene(3);
    }
}
