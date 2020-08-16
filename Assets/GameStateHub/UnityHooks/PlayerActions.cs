// GENERATED AUTOMATICALLY FROM 'Assets/GameStateHub/UnityHooks/PlayerActions.inputactions'

using System;
using UnityEngine;
using UnityEngine.Experimental.Input;


[Serializable]
public class PlayerActions : InputActionAssetReference
{
    public PlayerActions()
    {
    }
    public PlayerActions(InputActionAsset asset)
        : base(asset)
    {
    }
    private bool m_Initialized;
    private void Initialize()
    {
        // Menu
        m_Menu = asset.GetActionMap("Menu");
        m_Menu_MenuTraverse = m_Menu.GetAction("MenuTraverse");
        m_Menu_MenuTraverseRelease = m_Menu.GetAction("MenuTraverseRelease");
        m_Menu_MenuConfirm = m_Menu.GetAction("MenuConfirm");
        m_Menu_MenuEscape = m_Menu.GetAction("MenuEscape");
        // PlayMenu
        m_PlayMenu = asset.GetActionMap("PlayMenu");
        m_PlayMenu_PlayMenuTraverse = m_PlayMenu.GetAction("PlayMenuTraverse");
        m_PlayMenu_PlayMenuTraverseRelease = m_PlayMenu.GetAction("PlayMenuTraverseRelease");
        m_PlayMenu_PlayMenuConfirm = m_PlayMenu.GetAction("PlayMenuConfirm");
        m_PlayMenu_PlayMenuEscape = m_PlayMenu.GetAction("PlayMenuEscape");
        m_PlayMenu_PlayMenuTransitionToGame = m_PlayMenu.GetAction("PlayMenuTransitionToGame");
        // Play
        m_Play = asset.GetActionMap("Play");
        m_Play_PlayMove = m_Play.GetAction("PlayMove");
        m_Play_PlayMoveRelease = m_Play.GetAction("PlayMoveRelease");
        m_Play_PlayCameraMove = m_Play.GetAction("PlayCameraMove");
        m_Play_PlayCameraMoveRelease = m_Play.GetAction("PlayCameraMoveRelease");
        m_Play_PlayPause = m_Play.GetAction("PlayPause");
        m_Play_PlayJump = m_Play.GetAction("PlayJump");
        m_Play_PlayJumpRelease = m_Play.GetAction("PlayJumpRelease");
        m_Play_PlayTransitionToPlayMenu = m_Play.GetAction("PlayTransitionToPlayMenu");
        m_Initialized = true;
    }
    private void Uninitialize()
    {
        m_Menu = null;
        m_Menu_MenuTraverse = null;
        m_Menu_MenuTraverseRelease = null;
        m_Menu_MenuConfirm = null;
        m_Menu_MenuEscape = null;
        m_PlayMenu = null;
        m_PlayMenu_PlayMenuTraverse = null;
        m_PlayMenu_PlayMenuTraverseRelease = null;
        m_PlayMenu_PlayMenuConfirm = null;
        m_PlayMenu_PlayMenuEscape = null;
        m_PlayMenu_PlayMenuTransitionToGame = null;
        m_Play = null;
        m_Play_PlayMove = null;
        m_Play_PlayMoveRelease = null;
        m_Play_PlayCameraMove = null;
        m_Play_PlayCameraMoveRelease = null;
        m_Play_PlayPause = null;
        m_Play_PlayJump = null;
        m_Play_PlayJumpRelease = null;
        m_Play_PlayTransitionToPlayMenu = null;
        m_Initialized = false;
    }
    public void SetAsset(InputActionAsset newAsset)
    {
        if (newAsset == asset) return;
        if (m_Initialized) Uninitialize();
        asset = newAsset;
    }
    public override void MakePrivateCopyOfActions()
    {
        SetAsset(ScriptableObject.Instantiate(asset));
    }
    // Menu
    private InputActionMap m_Menu;
    private InputAction m_Menu_MenuTraverse;
    private InputAction m_Menu_MenuTraverseRelease;
    private InputAction m_Menu_MenuConfirm;
    private InputAction m_Menu_MenuEscape;
    public struct MenuActions
    {
        private PlayerActions m_Wrapper;
        public MenuActions(PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @MenuTraverse { get { return m_Wrapper.m_Menu_MenuTraverse; } }
        public InputAction @MenuTraverseRelease { get { return m_Wrapper.m_Menu_MenuTraverseRelease; } }
        public InputAction @MenuConfirm { get { return m_Wrapper.m_Menu_MenuConfirm; } }
        public InputAction @MenuEscape { get { return m_Wrapper.m_Menu_MenuEscape; } }
        public InputActionMap Get() { return m_Wrapper.m_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled { get { return Get().enabled; } }
        public InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
    }
    public MenuActions @Menu
    {
        get
        {
            if (!m_Initialized) Initialize();
            return new MenuActions(this);
        }
    }
    // PlayMenu
    private InputActionMap m_PlayMenu;
    private InputAction m_PlayMenu_PlayMenuTraverse;
    private InputAction m_PlayMenu_PlayMenuTraverseRelease;
    private InputAction m_PlayMenu_PlayMenuConfirm;
    private InputAction m_PlayMenu_PlayMenuEscape;
    private InputAction m_PlayMenu_PlayMenuTransitionToGame;
    public struct PlayMenuActions
    {
        private PlayerActions m_Wrapper;
        public PlayMenuActions(PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @PlayMenuTraverse { get { return m_Wrapper.m_PlayMenu_PlayMenuTraverse; } }
        public InputAction @PlayMenuTraverseRelease { get { return m_Wrapper.m_PlayMenu_PlayMenuTraverseRelease; } }
        public InputAction @PlayMenuConfirm { get { return m_Wrapper.m_PlayMenu_PlayMenuConfirm; } }
        public InputAction @PlayMenuEscape { get { return m_Wrapper.m_PlayMenu_PlayMenuEscape; } }
        public InputAction @PlayMenuTransitionToGame { get { return m_Wrapper.m_PlayMenu_PlayMenuTransitionToGame; } }
        public InputActionMap Get() { return m_Wrapper.m_PlayMenu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled { get { return Get().enabled; } }
        public InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator InputActionMap(PlayMenuActions set) { return set.Get(); }
    }
    public PlayMenuActions @PlayMenu
    {
        get
        {
            if (!m_Initialized) Initialize();
            return new PlayMenuActions(this);
        }
    }
    // Play
    private InputActionMap m_Play;
    private InputAction m_Play_PlayMove;
    private InputAction m_Play_PlayMoveRelease;
    private InputAction m_Play_PlayCameraMove;
    private InputAction m_Play_PlayCameraMoveRelease;
    private InputAction m_Play_PlayPause;
    private InputAction m_Play_PlayJump;
    private InputAction m_Play_PlayJumpRelease;
    private InputAction m_Play_PlayTransitionToPlayMenu;
    public struct PlayActions
    {
        private PlayerActions m_Wrapper;
        public PlayActions(PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @PlayMove { get { return m_Wrapper.m_Play_PlayMove; } }
        public InputAction @PlayMoveRelease { get { return m_Wrapper.m_Play_PlayMoveRelease; } }
        public InputAction @PlayCameraMove { get { return m_Wrapper.m_Play_PlayCameraMove; } }
        public InputAction @PlayCameraMoveRelease { get { return m_Wrapper.m_Play_PlayCameraMoveRelease; } }
        public InputAction @PlayPause { get { return m_Wrapper.m_Play_PlayPause; } }
        public InputAction @PlayJump { get { return m_Wrapper.m_Play_PlayJump; } }
        public InputAction @PlayJumpRelease { get { return m_Wrapper.m_Play_PlayJumpRelease; } }
        public InputAction @PlayTransitionToPlayMenu { get { return m_Wrapper.m_Play_PlayTransitionToPlayMenu; } }
        public InputActionMap Get() { return m_Wrapper.m_Play; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled { get { return Get().enabled; } }
        public InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator InputActionMap(PlayActions set) { return set.Get(); }
    }
    public PlayActions @Play
    {
        get
        {
            if (!m_Initialized) Initialize();
            return new PlayActions(this);
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get

        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.GetControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_KeyboardAndMouseSchemeIndex = -1;
    public InputControlScheme KeyboardAndMouseScheme
    {
        get

        {
            if (m_KeyboardAndMouseSchemeIndex == -1) m_KeyboardAndMouseSchemeIndex = asset.GetControlSchemeIndex("KeyboardAndMouse");
            return asset.controlSchemes[m_KeyboardAndMouseSchemeIndex];
        }
    }
}
