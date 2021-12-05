using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("inputTest");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
