// GENERATED AUTOMATICALLY FROM 'Assets/InputManagement/PlayerInputManager/PlayerActions.inputactions'

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
        // Gameplay
        m_Gameplay = asset.GetActionMap("Gameplay");
        m_Gameplay_GameplayJump = m_Gameplay.GetAction("GameplayJump");
        m_Gameplay_GameplayJumpRelease = m_Gameplay.GetAction("GameplayJumpRelease");
        m_Gameplay_GameplayMove = m_Gameplay.GetAction("GameplayMove");
        m_Gameplay_GameplayMoveRelease = m_Gameplay.GetAction("GameplayMoveRelease");
        m_Gameplay_GameplayCameraMove = m_Gameplay.GetAction("GameplayCameraMove");
        m_Gameplay_GameplayCameraMoveRelease = m_Gameplay.GetAction("GameplayCameraMoveRelease");
        m_Gameplay_GameplayMenu = m_Gameplay.GetAction("GameplayMenu");
        m_Gameplay_GameplayPause = m_Gameplay.GetAction("GameplayPause");
        // GameplayMenu
        m_GameplayMenu = asset.GetActionMap("GameplayMenu");
        m_GameplayMenu_GameMenuTraverse = m_GameplayMenu.GetAction("GameMenuTraverse");
        m_GameplayMenu_GameMenuTraverseRelease = m_GameplayMenu.GetAction("GameMenuTraverseRelease");
        m_GameplayMenu_GameMenuConfirm = m_GameplayMenu.GetAction("GameMenuConfirm");
        m_GameplayMenu_GameMenuEscape = m_GameplayMenu.GetAction("GameMenuEscape");
        m_GameplayMenu_GameMenuExit = m_GameplayMenu.GetAction("GameMenuExit");
        // Menu
        m_Menu = asset.GetActionMap("Menu");
        m_Menu_MenuTraverse = m_Menu.GetAction("MenuTraverse");
        m_Menu_MenuTraverseRelease = m_Menu.GetAction("MenuTraverseRelease");
        m_Menu_MenuConfirm = m_Menu.GetAction("MenuConfirm");
        m_Menu_MenuEscape = m_Menu.GetAction("MenuEscape");
        m_Initialized = true;
    }
    private void Uninitialize()
    {
        m_Gameplay = null;
        m_Gameplay_GameplayJump = null;
        m_Gameplay_GameplayJumpRelease = null;
        m_Gameplay_GameplayMove = null;
        m_Gameplay_GameplayMoveRelease = null;
        m_Gameplay_GameplayCameraMove = null;
        m_Gameplay_GameplayCameraMoveRelease = null;
        m_Gameplay_GameplayMenu = null;
        m_Gameplay_GameplayPause = null;
        m_GameplayMenu = null;
        m_GameplayMenu_GameMenuTraverse = null;
        m_GameplayMenu_GameMenuTraverseRelease = null;
        m_GameplayMenu_GameMenuConfirm = null;
        m_GameplayMenu_GameMenuEscape = null;
        m_GameplayMenu_GameMenuExit = null;
        m_Menu = null;
        m_Menu_MenuTraverse = null;
        m_Menu_MenuTraverseRelease = null;
        m_Menu_MenuConfirm = null;
        m_Menu_MenuEscape = null;
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
    // Gameplay
    private InputActionMap m_Gameplay;
    private InputAction m_Gameplay_GameplayJump;
    private InputAction m_Gameplay_GameplayJumpRelease;
    private InputAction m_Gameplay_GameplayMove;
    private InputAction m_Gameplay_GameplayMoveRelease;
    private InputAction m_Gameplay_GameplayCameraMove;
    private InputAction m_Gameplay_GameplayCameraMoveRelease;
    private InputAction m_Gameplay_GameplayMenu;
    private InputAction m_Gameplay_GameplayPause;
    public struct GameplayActions
    {
        private PlayerActions m_Wrapper;
        public GameplayActions(PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @GameplayJump { get { return m_Wrapper.m_Gameplay_GameplayJump; } }
        public InputAction @GameplayJumpRelease { get { return m_Wrapper.m_Gameplay_GameplayJumpRelease; } }
        public InputAction @GameplayMove { get { return m_Wrapper.m_Gameplay_GameplayMove; } }
        public InputAction @GameplayMoveRelease { get { return m_Wrapper.m_Gameplay_GameplayMoveRelease; } }
        public InputAction @GameplayCameraMove { get { return m_Wrapper.m_Gameplay_GameplayCameraMove; } }
        public InputAction @GameplayCameraMoveRelease { get { return m_Wrapper.m_Gameplay_GameplayCameraMoveRelease; } }
        public InputAction @GameplayMenu { get { return m_Wrapper.m_Gameplay_GameplayMenu; } }
        public InputAction @GameplayPause { get { return m_Wrapper.m_Gameplay_GameplayPause; } }
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled { get { return Get().enabled; } }
        public InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
    }
    public GameplayActions @Gameplay
    {
        get
        {
            if (!m_Initialized) Initialize();
            return new GameplayActions(this);
        }
    }
    // GameplayMenu
    private InputActionMap m_GameplayMenu;
    private InputAction m_GameplayMenu_GameMenuTraverse;
    private InputAction m_GameplayMenu_GameMenuTraverseRelease;
    private InputAction m_GameplayMenu_GameMenuConfirm;
    private InputAction m_GameplayMenu_GameMenuEscape;
    private InputAction m_GameplayMenu_GameMenuExit;
    public struct GameplayMenuActions
    {
        private PlayerActions m_Wrapper;
        public GameplayMenuActions(PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @GameMenuTraverse { get { return m_Wrapper.m_GameplayMenu_GameMenuTraverse; } }
        public InputAction @GameMenuTraverseRelease { get { return m_Wrapper.m_GameplayMenu_GameMenuTraverseRelease; } }
        public InputAction @GameMenuConfirm { get { return m_Wrapper.m_GameplayMenu_GameMenuConfirm; } }
        public InputAction @GameMenuEscape { get { return m_Wrapper.m_GameplayMenu_GameMenuEscape; } }
        public InputAction @GameMenuExit { get { return m_Wrapper.m_GameplayMenu_GameMenuExit; } }
        public InputActionMap Get() { return m_Wrapper.m_GameplayMenu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled { get { return Get().enabled; } }
        public InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator InputActionMap(GameplayMenuActions set) { return set.Get(); }
    }
    public GameplayMenuActions @GameplayMenu
    {
        get
        {
            if (!m_Initialized) Initialize();
            return new GameplayMenuActions(this);
        }
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
