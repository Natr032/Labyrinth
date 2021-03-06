// GENERATED AUTOMATICALLY FROM 'Assets/Input/SimpleControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @SimpleControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @SimpleControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""SimpleControls"",
    ""maps"": [
        {
            ""name"": ""gameplay"",
            ""id"": ""265c38f5-dd18-4d34-b198-aec58e1627ff"",
            ""actions"": [
                {
                    ""name"": ""move"",
                    ""type"": ""Value"",
                    ""id"": ""50fd2809-3aa3-4a90-988e-1facf6773553"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""look"",
                    ""type"": ""Value"",
                    ""id"": ""c60e0974-d140-4597-a40e-9862193067e9"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""jump"",
                    ""type"": ""Button"",
                    ""id"": ""cead56bb-e12c-46f0-a795-1ffedf77d0e1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""defaultAllCells"",
                    ""type"": ""Button"",
                    ""id"": ""afa7ca51-7cba-4d0b-aa50-039d1160b274"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""oneRandomCellUp"",
                    ""type"": ""Button"",
                    ""id"": ""13d6a3cd-2ec1-4192-b003-fa5bb7e4ad27"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""oneRandomCellDown"",
                    ""type"": ""Button"",
                    ""id"": ""d7c56cce-b67f-48ff-9915-16bfb6db062e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""allCellsUp"",
                    ""type"": ""Button"",
                    ""id"": ""46a43179-49d5-498d-9ca2-7f812134f5ee"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e1b8c4dd-7b3a-4db6-a93a-0889b59b1afc"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Dpad"",
                    ""id"": ""cefc16fc-557a-44b0-939f-2ad792876b07"",
                    ""path"": ""Dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""07244659-79df-461d-b329-defbe2fbc5f6"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f0ec75cb-f02c-40d2-a33f-1fd6eab2ae0b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""21fe6bfe-4721-4483-9f4a-a0031ade105c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2dd39746-c75c-4a11-838a-e59eacaf4e0b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c106d6e6-2780-47ff-b318-396171bd54cc"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""578caa03-6827-4797-adfc-a59770c437fe"",
                    ""path"": ""<Pointer>/delta"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=2,y=2)"",
                    ""groups"": """",
                    ""action"": ""look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""30a74f71-c03f-487e-8178-0b46a1a88059"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4017ff27-f290-422e-a2ce-1eda41aa4f6d"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""defaultAllCells"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3601b78d-20e4-4fcf-9435-516399d6e542"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""oneRandomCellUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""adf54d6b-3274-43b5-ba0a-5f351d1b329a"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""oneRandomCellDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""58b662a3-3614-4893-9345-081ed8a81460"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""allCellsUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // gameplay
        m_gameplay = asset.FindActionMap("gameplay", throwIfNotFound: true);
        m_gameplay_move = m_gameplay.FindAction("move", throwIfNotFound: true);
        m_gameplay_look = m_gameplay.FindAction("look", throwIfNotFound: true);
        m_gameplay_jump = m_gameplay.FindAction("jump", throwIfNotFound: true);
        m_gameplay_defaultAllCells = m_gameplay.FindAction("defaultAllCells", throwIfNotFound: true);
        m_gameplay_oneRandomCellUp = m_gameplay.FindAction("oneRandomCellUp", throwIfNotFound: true);
        m_gameplay_oneRandomCellDown = m_gameplay.FindAction("oneRandomCellDown", throwIfNotFound: true);
        m_gameplay_allCellsUp = m_gameplay.FindAction("allCellsUp", throwIfNotFound: true);
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

    // gameplay
    private readonly InputActionMap m_gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_gameplay_move;
    private readonly InputAction m_gameplay_look;
    private readonly InputAction m_gameplay_jump;
    private readonly InputAction m_gameplay_defaultAllCells;
    private readonly InputAction m_gameplay_oneRandomCellUp;
    private readonly InputAction m_gameplay_oneRandomCellDown;
    private readonly InputAction m_gameplay_allCellsUp;
    public struct GameplayActions
    {
        private @SimpleControls m_Wrapper;
        public GameplayActions(@SimpleControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @move => m_Wrapper.m_gameplay_move;
        public InputAction @look => m_Wrapper.m_gameplay_look;
        public InputAction @jump => m_Wrapper.m_gameplay_jump;
        public InputAction @defaultAllCells => m_Wrapper.m_gameplay_defaultAllCells;
        public InputAction @oneRandomCellUp => m_Wrapper.m_gameplay_oneRandomCellUp;
        public InputAction @oneRandomCellDown => m_Wrapper.m_gameplay_oneRandomCellDown;
        public InputAction @allCellsUp => m_Wrapper.m_gameplay_allCellsUp;
        public InputActionMap Get() { return m_Wrapper.m_gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                @move.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @move.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @move.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                @look.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLook;
                @look.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLook;
                @look.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnLook;
                @jump.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @jump.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @jump.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                @defaultAllCells.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDefaultAllCells;
                @defaultAllCells.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDefaultAllCells;
                @defaultAllCells.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDefaultAllCells;
                @oneRandomCellUp.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnOneRandomCellUp;
                @oneRandomCellUp.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnOneRandomCellUp;
                @oneRandomCellUp.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnOneRandomCellUp;
                @oneRandomCellDown.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnOneRandomCellDown;
                @oneRandomCellDown.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnOneRandomCellDown;
                @oneRandomCellDown.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnOneRandomCellDown;
                @allCellsUp.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAllCellsUp;
                @allCellsUp.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAllCellsUp;
                @allCellsUp.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAllCellsUp;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                @move.started += instance.OnMove;
                @move.performed += instance.OnMove;
                @move.canceled += instance.OnMove;
                @look.started += instance.OnLook;
                @look.performed += instance.OnLook;
                @look.canceled += instance.OnLook;
                @jump.started += instance.OnJump;
                @jump.performed += instance.OnJump;
                @jump.canceled += instance.OnJump;
                @defaultAllCells.started += instance.OnDefaultAllCells;
                @defaultAllCells.performed += instance.OnDefaultAllCells;
                @defaultAllCells.canceled += instance.OnDefaultAllCells;
                @oneRandomCellUp.started += instance.OnOneRandomCellUp;
                @oneRandomCellUp.performed += instance.OnOneRandomCellUp;
                @oneRandomCellUp.canceled += instance.OnOneRandomCellUp;
                @oneRandomCellDown.started += instance.OnOneRandomCellDown;
                @oneRandomCellDown.performed += instance.OnOneRandomCellDown;
                @oneRandomCellDown.canceled += instance.OnOneRandomCellDown;
                @allCellsUp.started += instance.OnAllCellsUp;
                @allCellsUp.performed += instance.OnAllCellsUp;
                @allCellsUp.canceled += instance.OnAllCellsUp;
            }
        }
    }
    public GameplayActions @gameplay => new GameplayActions(this);
    public interface IGameplayActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnDefaultAllCells(InputAction.CallbackContext context);
        void OnOneRandomCellUp(InputAction.CallbackContext context);
        void OnOneRandomCellDown(InputAction.CallbackContext context);
        void OnAllCellsUp(InputAction.CallbackContext context);
    }
}
