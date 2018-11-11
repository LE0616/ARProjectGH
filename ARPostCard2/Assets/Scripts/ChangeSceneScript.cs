using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneScript : MonoBehaviour {

	public void greetingCard()
    {
        SceneManager.LoadScene("ARPostCardScene");
    }

    public void rotateCube()
    {
        SceneManager.LoadScene("RotateCube");
    }

    public void exitGame()
    {
        Application.Quit();
        Debug.Log("Exit Button pressed");
    }
}
