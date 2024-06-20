//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/InputActions/PlayerControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""PlayerControlsMap"",
            ""id"": ""a596f39b-4181-4241-b99d-4cce6d81d985"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""4bbb560b-16c2-4590-8744-5f37648ba6c5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e543eb8a-31c0-4ed3-9926-ffb0890fabe8"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""f6a5146f-7f63-42f6-abc4-a99c5701558d"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f12ec277-7e0a-4a3d-8b48-3f0c3be5327d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""29e4230a-593a-46b2-8def-3ec5d6eafa14"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""541e8f13-2cd1-4c9c-89d3-ac21f17caaca"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c1557c84-05d4-49d6-a7f8-216cf8e18b7c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerControlsMap
        m_PlayerControlsMap = asset.FindActionMap("PlayerControlsMap", throwIfNotFound: true);
        m_PlayerControlsMap_Move = m_PlayerControlsMap.FindAction("Move", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // PlayerControlsMap
    private readonly InputActionMap m_PlayerControlsMap;
    private List<IPlayerControlsMapActions> m_PlayerControlsMapActionsCallbackInterfaces = new List<IPlayerControlsMapActions>();
    private readonly InputAction m_PlayerControlsMap_Move;
    public struct PlayerControlsMapActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerControlsMapActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerControlsMap_Move;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControlsMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlsMapActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerControlsMapActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerControlsMapActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerControlsMapActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
        }

        private void UnregisterCallbacks(IPlayerControlsMapActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
        }

        public void RemoveCallbacks(IPlayerControlsMapActions instance)
        {
            if (m_Wrapper.m_PlayerControlsMapActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerControlsMapActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerControlsMapActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerControlsMapActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerControlsMapActions @PlayerControlsMap => new PlayerControlsMapActions(this);
    public interface IPlayerControlsMapActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
}
