using UnityEngine;
using UnityEngine.Experimental.Input.Plugins.PlayerInput;

using PlayerInputStore;
using PlayerInputStore.Actions;

public class PlayerInputManagerHooks : MonoBehaviour
{
    public Store store;


    private void Awake()
    {
        this.store = new Store();

        // Persist PlayerInputManager && PlayerInputManagerHooks between scenes
        DontDestroyOnLoad(this);
    }

    void OnPlayerJoined(PlayerInput playerInput)
    {
        Action<PlayerInput> action = new Action<PlayerInput>(
            "PLAYER_JOINED_GAME",
            playerInput.user.id,
            playerInput
        );
        this.store.SendAction(action);
    }

    void OnPlayerLeft(PlayerInput playerInput)
    {
        Action<PlayerInput> action = new Action<PlayerInput>(
            "PLAYER_LEFT_GAME",
            playerInput.user.id,
            playerInput
        );
        this.store.SendAction(action);
    }

    void OnApplicationFocus(bool isFocused)
    {
        Action<bool> action = new Action<bool>(
            "APPLICATION_BLUR",
            -1,
            isFocused
        );

        if (isFocused)
        {
            action = new Action<bool>(
                "APPLICATION_FOCUS",
                -1,
                isFocused
            );
        }

        this.store.SendAction(action);
    }
}
