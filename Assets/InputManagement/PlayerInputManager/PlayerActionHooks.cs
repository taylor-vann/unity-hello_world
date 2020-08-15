using UnityEngine;
using UnityEngine.Experimental.Input.Plugins.PlayerInput;

using GameActions;
using PlayerInputStore;
using PlayerInputStore.Actions;


public class PlayerActionHooks : MonoBehaviour
{

    private Store actionsStore;
    private uint userId;


    void Awake()
    {
        // Persist PlayerInput && PlayerActionHooks between scenes
        DontDestroyOnLoad(this);

        this.actionsStore = PlayerInputManager
            .instance.GetComponent<PlayerInputManagerHooks>()
            .store;
        this.userId = this.GetComponent<PlayerInput>().user.id;
    }

    // Players

    void OnDeviceLost(PlayerInput playerInput)
    {
        Action<PlayerInput> action = new Action<PlayerInput>(
            ActionFlags.DeviceLost,
            this.userId,
            playerInput
        );

        this.actionsStore.SendAction(action);
    }

    void OnDeviceRegained(PlayerInput playerInput)
    {
        Action<PlayerInput> action = new Action<PlayerInput>(
            ActionFlags.DeviceRegained,
            this.userId,
            playerInput
        );

        this.actionsStore.SendAction(action);
    }

    // Menu

    void OnMenuTraverse(InputValue inputValue)
    {
        Action<InputValue> action = new Action<InputValue>(
            ActionFlags.MenuTraverse,
            this.userId,
            inputValue
        );

        this.actionsStore.SendAction(action);
    }

    void OnMenuTraverseRelease(InputValue inputValue)
    {
        Action<InputValue> action = new Action<InputValue>(
            ActionFlags.MenuTraverseRelease,
            this.userId,
            inputValue
        );

        this.actionsStore.SendAction(action);
    }

    void OnMenuConfirm(InputValue inputValue)
    {
        Action<InputValue> action = new Action<InputValue>(
            ActionFlags.MenuConfirm,
            this.userId,
            inputValue
        );

        this.actionsStore.SendAction(action);
    }

    void OnMenuEscape(InputValue inputValue)
    {
        Action<InputValue> action = new Action<InputValue>(
            ActionFlags.MenuEscape,
            this.userId,
            inputValue
        );

        this.actionsStore.SendAction(action);
    }

    // PlayMenu

    void OnPlayMenuTraverse(InputValue inputValue)
    {
        Action<InputValue> action = new Action<InputValue>(
            ActionFlags.PlayMenuTraverse,
            this.userId,
            inputValue
        );

        this.actionsStore.SendAction(action);
    }

    void OnPlayMenuTraverseRelease(InputValue inputValue)
    {
        Action<InputValue> action = new Action<InputValue>(
            ActionFlags.PlayMenuTraverseRelease,
            this.userId,
            inputValue
        );

        this.actionsStore.SendAction(action);
    }

    void OnPlayMenuConfirm(InputValue inputValue)
    {
        Action<InputValue> action = new Action<InputValue>(
            ActionFlags.PlayMenuConfirm,
            this.userId,
            inputValue
        );

        this.actionsStore.SendAction(action);
    }

    void OnPlayMenuEscape(InputValue inputValue)
    {
        Action<InputValue> action = new Action<InputValue>(
            ActionFlags.PlayMenuEscape,
            this.userId,
            inputValue
        );

        this.actionsStore.SendAction(action);
    }

    void OnPlayMenuTransitionToGame(InputValue inputValue)
    {
        Action<InputValue> action = new Action<InputValue>(
            ActionFlags.PlayMenuTransitionToGame,
            this.userId,
            inputValue
        );

        this.actionsStore.SendAction(action);
    }

    // Play

    void OnPlayMove(InputValue inputValue)
    {
        Action<InputValue> action = new Action<InputValue>(
            ActionFlags.PlayMove,
            this.userId,
            inputValue
        );

        this.actionsStore.SendAction(action);
    }

    void OnPlayMoveRelease(InputValue inputValue)
    {
        Action<InputValue> action = new Action<InputValue>(
            ActionFlags.PlayMoveRelease,
            this.userId,
            inputValue
        );

        this.actionsStore.SendAction(action);
    }

    void OnPlayCameraMove(InputValue inputValue)
    {
        Action<InputValue> action = new Action<InputValue>(
            ActionFlags.PlayCameraMove,
            this.userId,
            inputValue
        );

        this.actionsStore.SendAction(action);
    }

    void OnPlayCameraMoveRelease(InputValue inputValue)
    {
        Action<InputValue> action = new Action<InputValue>(
            ActionFlags.PlayCameraMoveRelease,
            this.userId,
            inputValue
        );

        this.actionsStore.SendAction(action);
    }

    void OnPlayPause(InputValue inputValue)
    {
        Action<InputValue> action = new Action<InputValue>(
            ActionFlags.PlayPause,
            this.userId,
            inputValue
        );

        this.actionsStore.SendAction(action);
    }

    void OnPlayJump(InputValue inputValue)
    {
        Action<InputValue> action = new Action<InputValue>(
            ActionFlags.PlayJump,
            this.userId,
            inputValue
        );

        this.actionsStore.SendAction(action);
    }

    void OnPlayJumpRelease(InputValue inputValue)
    {
        Action<InputValue> action = new Action<InputValue>(
            ActionFlags.PlayJumpRelease,
            this.userId,
            inputValue
        );

        this.actionsStore.SendAction(action);
    }

    void OnPlayTransitionToPlayMenu(InputValue inputValue)
    {
        Action<InputValue> action = new Action<InputValue>(
            ActionFlags.PlayTransitionToPlayMenu,
            this.userId,
            inputValue
        );

        this.actionsStore.SendAction(action);
    }
}
