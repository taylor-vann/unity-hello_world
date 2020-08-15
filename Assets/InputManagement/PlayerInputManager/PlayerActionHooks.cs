using UnityEngine;
using UnityEngine.Experimental.Input.Plugins.PlayerInput;

using PlayerInputStore;
using PlayerInputStore.Actions;



public class PlayerActionHooks : MonoBehaviour
{

    private Store actionsStore;
    private uint userId;


    void Awake()
    {
        this.actionsStore = PlayerInputManager
            .instance.GetComponent<PlayerInputManagerHooks>()
            .store;
        this.userId = this.GetComponent<PlayerInput>().user.id;

        // Persist PlayerInput && PlayerActionHooks between scenes
        DontDestroyOnLoad(this);
    }

    void OnDeviceLost(PlayerInput playerInput)
    {
        Action<PlayerInput> action = new Action<PlayerInput>(
            "PLAYER_DEVICE_LOST",
            this.userId,
            playerInput
        );

        this.actionsStore.SendAction(action);
    }

    void OnDeviceRegained(PlayerInput playerInput)
    {
        Action<PlayerInput> action = new Action<PlayerInput>(
            "PLAYER_DEVICE_REGAINED",
            this.userId,
            playerInput
        );

        this.actionsStore.SendAction(action);
    }

    void OnGameplayJump(InputValue inputValue)
    {
        Action<InputValue> action = new Action<InputValue>(
            "GAMEPLAY_JUMP",
            this.userId,
            inputValue
        );

        this.actionsStore.SendAction(action);
    }

    void OnGameplayJumpRelease(InputValue inputValue)
    {
        Action<InputValue> action = new Action<InputValue>(
            "GAMEPLAY_JUMP_RELEASE",
            this.userId,
            inputValue
        );

        this.actionsStore.SendAction(action);
    }

    void OnGameplayMove(InputValue inputValue)
    {
        Action<InputValue> action = new Action<InputValue>(
            "GAMEPLAY_MOVE",
            this.userId,
            inputValue
        );

        this.actionsStore.SendAction(action);
    }

    void OnGameplayMoveRelease(InputValue inputValue)
    {
        Action<InputValue> action = new Action<InputValue>(
            "GAMEPLAY_MOVE_RELEASE",
            this.userId,
            inputValue
        );

        this.actionsStore.SendAction(action);
    }

    void OnGameplayCameraMove(InputValue inputValue)
    {
        Action<InputValue> action = new Action<InputValue>(
            "GAMEPLAY_CAMERA_MOVE",
            this.userId,
            inputValue
        );

        this.actionsStore.SendAction(action);
    }

    void OnGameplayCameraMoveRelease(InputValue inputValue)
    {
        Action<InputValue> action = new Action<InputValue>(
            "GAMEPLAY_CAMERA_MOVE_RELEASE",
            this.userId,
            inputValue
        );

        this.actionsStore.SendAction(action);
    }
}
