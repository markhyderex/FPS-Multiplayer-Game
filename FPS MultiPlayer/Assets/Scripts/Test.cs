using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Test : MonoBehaviour
{
    public void Starts()
    {
        SceneManager.LoadScene("Lobby");
    }
    public void Credit()
    {
        SceneManager.LoadScene("Instructions");
    }
    public void Return()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
