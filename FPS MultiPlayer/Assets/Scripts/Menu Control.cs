using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Starts()
    {
        SceneManager.LoadScene("Lobby");
    }
    void Credit()
    {
        SceneManager.LoadScene("Instructions");
    }
    void Return()
    {
        SceneManager.LoadScene("Main Menu");
    }
    void Quit()
    {
        Application.Quit();
    }
}
