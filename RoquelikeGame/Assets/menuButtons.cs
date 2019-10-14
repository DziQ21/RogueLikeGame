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
}
