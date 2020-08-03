using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Input.Plugins.PlayerInput;


public class PlayerActionHooks : MonoBehaviour
{

    private PlayerInputManagerHooks playerInputManagerHooks;
    private PlayerInput userInput;
    private uint userId;

    void Awake()
    {
        this.playerInputManagerHooks =
            PlayerInputManager.instance.GetComponent<PlayerInputManagerHooks>();

        this.userInput = this.GetComponent<PlayerInput>();
        this.userId = this.userInput.user.id;

        this.playerInputManagerHooks.Ping(this.userId);
    }

    private void OnDestroy()
    {

    }

    void OnDeviceLost()
    {

    }

    void OnDeviceRegained()
    {

    }

    void OnEnable()
    {
        Debug.Log("PlayerActionsHooks.OnEnable()");
    }

    void OnMove()
    {
        Debug.Log("PlayerActionHooks.OnMove()");
    }

    void OnAction()
    {
        Debug.Log("PlayerActionHooks.OnAction()");
    }

    void OnCancel()
    {
        Debug.Log("PlayerActionHooks.OnCancel()");
    }

    void OnConfirm()
    {
        Debug.Log("PlayerActionHooks.OnConfirm()");
    }

    void OnEscape()
    {
        Debug.Log("PlayerACtionHooks.OnEscape()");
    }

    void OnTraverse()
    {
        Debug.Log("PlayerACtionHooks.OnTraverse()");
    }
}
