using UnityEngine;
using UnityEngine.Experimental.Input.Plugins.PlayerInput;

using PlayerInputStore;
using PlayerInputStore.Actions;
using GameActions;

public class PlayerInputManagerHooks : MonoBehaviour
{
    public Store store;


    private void Awake()
    {
        // Persist PlayerInputManager && PlayerInputManagerHooks between scenes
        DontDestroyOnLoad(this);

        this.store = new Store();
    }

    // Base

    void OnApplicationFocus(bool isFocused)
    {
        Action<bool> action;

        if (isFocused)
        {
            action = new Action<bool>(
                ActionFlags.ApplicationGainedFocus,
                -1,
                isFocused
            );

            this.store.SendAction(action);
            return;
        }

        action = new Action<bool>(
            ActionFlags.ApplicationLostFocus,
            -1,
            isFocused
        );

        this.store.SendAction(action);
    }

    // Players

    void OnPlayerJoined(PlayerInput playerInput)
    {
        Action<PlayerInput> action = new Action<PlayerInput>(
            ActionFlags.PlayerJoined,
            playerInput.user.id,
            playerInput
        );

        this.store.SendAction(action);
    }

    void OnPlayerLeft(PlayerInput playerInput)
    {
        Action<PlayerInput> action = new Action<PlayerInput>(
            ActionFlags.PlayerLeft,
            playerInput.user.id,
            playerInput
        );

        this.store.SendAction(action);
    }
}
