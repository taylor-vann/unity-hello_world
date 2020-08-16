using UnityEngine;
using UnityEngine.Experimental.Input.Plugins.PlayerInput;

using GameStateHub.GameActions;
using GameStateHub.GameStores;
using PlayerInputStore.Actions;

public class PlayerInputManagerHooks : MonoBehaviour
{

    public Stores stores;

    private void Awake()
    {
        // Persist PlayerInputManager && PlayerInputManagerHooks between scenes
        DontDestroyOnLoad(this);

        this.stores = new Stores();
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

            this.stores.SendAction(action);
            return;
        }

        action = new Action<bool>(
            ActionFlags.ApplicationLostFocus,
            -1,
            isFocused
        );

        this.stores.SendAction(action);
    }

    // Players

    void OnPlayerJoined(PlayerInput playerInput)
    {
        Action<PlayerInput> action = new Action<PlayerInput>(
            ActionFlags.PlayerJoined,
            playerInput.user.id,
            playerInput
        );

        this.stores.SendAction(action);
    }

    void OnPlayerLeft(PlayerInput playerInput)
    {
        Action<PlayerInput> action = new Action<PlayerInput>(
            ActionFlags.PlayerLeft,
            playerInput.user.id,
            playerInput
        );

        this.stores.SendAction(action);
    }
}
