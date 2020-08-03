using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input.Plugins.PlayerInput;

public class PlayerInputManagerHooks : MonoBehaviour
{
    private void Awake()
    {
        // Instance should survive Scenes and Loading
        DontDestroyOnLoad(this);
    }

    public void Ping(uint userId)
    {
        Debug.Log("User " + userId + "is read to play!");
    }

    void OnPlayerJoined(PlayerInput playerInput)
    {

    }

    void OnPlayerLeft(PlayerInput playerInput)
    {

    }
}
