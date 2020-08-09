using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input.Plugins.PlayerInput;

using PlayerInputStore;

public class PlayerInputManagerHooks : MonoBehaviour
{
    public PlayerActionsStore playerActionsStore;

    private void Awake()
    {
        // Persist PlayerInputManager && PlayerInputManagerHooks between scenes
        DontDestroyOnLoad(this);

        // create store
        this.playerActionsStore = new PlayerActionsStore();
    }

    void OnPlayerJoined(PlayerInput playerInput)
    {
        // register with player playerActionsStore
    }

    void OnPlayerLeft(PlayerInput playerInput)
    {
        // unregister with player playerActionsStore
    }
}
