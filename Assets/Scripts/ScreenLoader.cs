using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenLoader : MonoBehaviour
{

	public void LoadNextScreen()
    {
        var currentScreenIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScreenIndex + 1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void LoadStartScreen()
    {
        SceneManager.LoadScene(0);
    }

    public void Update()
    {
        //if(!FindObjectOfType<BlockBehaviour>())
        //{
        //    var currentScreenIndex = SceneManager.GetActiveScene().buildIndex;
        //    SceneManager.LoadScene(currentScreenIndex + 1);
        //}
    }
}
