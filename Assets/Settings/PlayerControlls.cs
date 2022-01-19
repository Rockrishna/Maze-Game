// GENERATED AUTOMATICALLY FROM 'Assets/Settings/PlayerControlls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControlls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControlls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControlls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""63fd45f0-803d-472e-81ab-9e4e0a552401"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""c183f72a-0b49-4db4-b58a-ac6f6105f10b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RunK"",
                    ""type"": ""Button"",
                    ""id"": ""067a258f-7bbc-49d0-9f3d-f66ee9637523"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RunC"",
                    ""type"": ""Button"",
                    ""id"": ""595a6d20-7ccd-40f2-9d80-6db7b75ebaa3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cheat1"",
                    ""type"": ""Button"",
                    ""id"": ""b01b05c4-4634-4f2e-8850-b23dbb6dd8cc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cheat2"",
                    ""type"": ""Button"",
                    ""id"": ""230ac3da-8a0d-4bb3-9b24-220f73801df2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PauseK"",
                    ""type"": ""Button"",
                    ""id"": ""01084e5a-2f5b-4132-9f59-dbcba434fb6d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PauseT"",
                    ""type"": ""Button"",
                    ""id"": ""049b8d98-2d2f-42bf-a399-0df64d66f592"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""af7cd7b8-43b2-4a42-bb36-025e8f2e8df2"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c5690c0d-7203-433b-84c7-d389f1676cfe"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RunK"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e06bbc48-60bf-4388-b977-35ee5dbfb46b"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RunC"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3e360940-db58-4224-a9d0-7b2dbbb5426c"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cheat1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""587eab27-aeb3-4099-8d80-f84007f03da3"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Cheat2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b8909084-a707-406f-879b-7359ea75ab84"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PauseK"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bfc79be9-df62-40ca-ace7-e30bf9f2d5d4"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PauseT"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Jump = m_Gameplay.FindAction("Jump", throwIfNotFound: true);
        m_Gameplay_RunK = m_Gameplay.FindAction("RunK", throwIfNotFound: true);
        m_Gameplay_RunC = m_Gameplay.FindAction("RunC", throwIfNotFound: true);
        m_Gameplay_Cheat1 = m_Gameplay.FindAction("Cheat1", throwIfNotFound: true);
        m_Gameplay_Cheat2 = m_Gameplay.FindAction("Cheat2", throwIfNotFound: true);
        m_Gameplay_PauseK = m_Gameplay.FindAction("PauseK", throwIfNotFound: true);
        m_Gameplay_PauseT = m_Gameplay.FindAction("PauseT", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Jump;
    private readonly InputAction m_Gameplay_RunK;
    private readonly InputAction m_Gameplay_RunC;
    private readonly InputAction m_Gameplay_Cheat1;
    private readonly InputAction m_Gameplay_Cheat2;
    private readonly InputAction m_Gameplay_PauseK;
    private readonly InputAction m_Gameplay_PauseT;
    public struct GameplayActions
    {
        private @PlayerControlls m_Wrapper;
        public GameplayActions(@PlayerControlls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Gameplay_Jump;
        public InputAction @RunK => m_Wrapper.m_Gameplay_RunK;
        public InputAction @RunC => m_Wrapper.m_Gameplay_RunC;
        public InputAction @Cheat1 => m_Wrapper.m_Gameplay_Cheat1;
        public InputAction @Cheat2 => m_Wrapper.m_Gameplay_Cheat2;
        public InputAction @PauseK => m_Wrapper.m_Gameplay_PauseK;
        public InputAction @PauseT => m_Wrapper.m_Gameplay_PauseT;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @RunK.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRunK;
                @RunK.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRunK;
                @RunK.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRunK;
                @RunC.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRunC;
                @RunC.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRunC;
                @RunC.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnRunC;
                @Cheat1.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCheat1;
                @Cheat1.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCheat1;
                @Cheat1.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCheat1;
                @Cheat2.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCheat2;
                @Cheat2.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCheat2;
                @Cheat2.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCheat2;
                @PauseK.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPauseK;
                @PauseK.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPauseK;
                @PauseK.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPauseK;
                @PauseT.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPauseT;
                @PauseT.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPauseT;
                @PauseT.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPauseT;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @RunK.started += instance.OnRunK;
                @RunK.performed += instance.OnRunK;
                @RunK.canceled += instance.OnRunK;
                @RunC.started += instance.OnRunC;
                @RunC.performed += instance.OnRunC;
                @RunC.canceled += instance.OnRunC;
                @Cheat1.started += instance.OnCheat1;
                @Cheat1.performed += instance.OnCheat1;
                @Cheat1.canceled += instance.OnCheat1;
                @Cheat2.started += instance.OnCheat2;
                @Cheat2.performed += instance.OnCheat2;
                @Cheat2.canceled += instance.OnCheat2;
                @PauseK.started += instance.OnPauseK;
                @PauseK.performed += instance.OnPauseK;
                @PauseK.canceled += instance.OnPauseK;
                @PauseT.started += instance.OnPauseT;
                @PauseT.performed += instance.OnPauseT;
                @PauseT.canceled += instance.OnPauseT;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnRunK(InputAction.CallbackContext context);
        void OnRunC(InputAction.CallbackContext context);
        void OnCheat1(InputAction.CallbackContext context);
        void OnCheat2(InputAction.CallbackContext context);
        void OnPauseK(InputAction.CallbackContext context);
        void OnPauseT(InputAction.CallbackContext context);
    }
}
