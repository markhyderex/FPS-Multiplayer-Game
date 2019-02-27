using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class PlayerSetup : NetworkBehaviour
{
    [SerializeField] 
    Behaviour[] compToDisable;

    [SerializeField]
    string remoteLayerName = "RemotePlayer";

    public Camera sceneCamera;

    void Start()
    {
        //check if we are controlling the player
        if (!isLocalPlayer)
        { //if not, disabled these componenets

            // He moved to DisableComponents(){}
            //for (int i = 0; i < compToDisable.Length; i++)
            //{
            //    compToDisable[i].enabled = false;
            //}

            DisableComponents();
            AssignRemoteLayer();
        }
        else if (isLocalPlayer)
        {
            sceneCamera = Camera.main;
            if (sceneCamera != null)
            {
                sceneCamera.gameObject.SetActive(false);
            }
        }

        RegisterPlayer();
    }

    void RegisterPlayer()
    {
        string _ID = "Player " + GetComponent<NetworkIdentity>().netId;
        transform.name = _ID;
    }

    void DisableComponents()
    {
        for (int i = 0; i < compToDisable.Length; i++)
        {
            compToDisable[i].enabled = false;
        }
    }

    void AssignRemoteLayer()
    {
        gameObject.layer = LayerMask.NameToLayer(remoteLayerName);
    }

    private void OnDisable()
    {

        if (sceneCamera != null)
        {
            sceneCamera.gameObject.SetActive(true);
        }
    }
}
