using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackAndClose : MonoBehaviour {

	public void backbtn()
    {
        SceneManager.LoadScene("Menu");
    }

    public void exitbtn()
    {
        Application.Quit();
        Debug.Log("Exit button pressed");
    }

}
