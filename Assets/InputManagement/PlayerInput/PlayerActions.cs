// GENERATED AUTOMATICALLY FROM 'Assets/InputManagement/PlayerInput/PlayerActions.inputactions'

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
        m_Gameplay_Action = m_Gameplay.GetAction("Action");
        m_Gameplay_Cancel = m_Gameplay.GetAction("Cancel");
        m_Gameplay_Move = m_Gameplay.GetAction("Move");
        // MenuNavigation
        m_MenuNavigation = asset.GetActionMap("MenuNavigation");
        m_MenuNavigation_Confirm = m_MenuNavigation.GetAction("Confirm");
        m_MenuNavigation_Escape = m_MenuNavigation.GetAction("Escape");
        m_MenuNavigation_Traverse = m_MenuNavigation.GetAction("Traverse");
        m_Initialized = true;
    }
    private void Uninitialize()
    {
        m_Gameplay = null;
        m_Gameplay_Action = null;
        m_Gameplay_Cancel = null;
        m_Gameplay_Move = null;
        m_MenuNavigation = null;
        m_MenuNavigation_Confirm = null;
        m_MenuNavigation_Escape = null;
        m_MenuNavigation_Traverse = null;
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
    private InputAction m_Gameplay_Action;
    private InputAction m_Gameplay_Cancel;
    private InputAction m_Gameplay_Move;
    public struct GameplayActions
    {
        private PlayerActions m_Wrapper;
        public GameplayActions(PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Action { get { return m_Wrapper.m_Gameplay_Action; } }
        public InputAction @Cancel { get { return m_Wrapper.m_Gameplay_Cancel; } }
        public InputAction @Move { get { return m_Wrapper.m_Gameplay_Move; } }
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
    // MenuNavigation
    private InputActionMap m_MenuNavigation;
    private InputAction m_MenuNavigation_Confirm;
    private InputAction m_MenuNavigation_Escape;
    private InputAction m_MenuNavigation_Traverse;
    public struct MenuNavigationActions
    {
        private PlayerActions m_Wrapper;
        public MenuNavigationActions(PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Confirm { get { return m_Wrapper.m_MenuNavigation_Confirm; } }
        public InputAction @Escape { get { return m_Wrapper.m_MenuNavigation_Escape; } }
        public InputAction @Traverse { get { return m_Wrapper.m_MenuNavigation_Traverse; } }
        public InputActionMap Get() { return m_Wrapper.m_MenuNavigation; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled { get { return Get().enabled; } }
        public InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator InputActionMap(MenuNavigationActions set) { return set.Get(); }
    }
    public MenuNavigationActions @MenuNavigation
    {
        get
        {
            if (!m_Initialized) Initialize();
            return new MenuNavigationActions(this);
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
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get

        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.GetControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
}
