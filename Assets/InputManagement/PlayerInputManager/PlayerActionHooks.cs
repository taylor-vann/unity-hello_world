using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input.Plugins.PlayerInput;

using PlayerInputStore;


public class PlayerActionHooks : MonoBehaviour
{

    private PlayerActionsStore actionsStore;
    private uint userId;

    void Awake()
    {
        // Persist PlayerInput && PlayerActionHooks between scenes
        DontDestroyOnLoad(this);

        this.actionsStore = PlayerInputManager
            .instance.GetComponent<PlayerInputManagerHooks>()
            .playerActionsStore;
        this.userId = this.GetComponent<PlayerInput>().user.id;
    }

    // TODO: Connect actions calls to PlayerActionsStore
}
