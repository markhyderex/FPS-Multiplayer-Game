using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;


public class PlayerSetup : NetworkBehaviour
{
    [SerializeField] 
    Behaviour[] compToDisable;

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
    }

}
