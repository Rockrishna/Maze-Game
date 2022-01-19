using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{

    public void PlayGame()
    { 
        SceneManager.LoadScene("Instructions");
    }
    public void ExitGame ()
    {
        Application.Quit();
    }
    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
