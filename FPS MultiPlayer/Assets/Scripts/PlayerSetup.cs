using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class PlayerSetup : NetworkBehaviour
{
    [SerializeField] 
    Behaviour[] compToDisable;

    public Camera sceneCamera;

    void Start()
    {
        //check if we are controlling the player
        if (!isLocalPlayer)
        { //if not, disabled these componenets
            for (int i = 0; i < compToDisable.Length; i++)
            {
                compToDisable[i].enabled = false;
            }
        }
        else if (isLocalPlayer)
        {
            print("sdsad");
            sceneCamera = Camera.main;
            if (sceneCamera != null)
            {
                sceneCamera.gameObject.SetActive(false);
            }
            Camera.main.gameObject.SetActive(true);
        }
    }

    private void OnDisable()
    {

        if (sceneCamera != null)
        {
            sceneCamera.gameObject.SetActive(true);
        }
    }
}
