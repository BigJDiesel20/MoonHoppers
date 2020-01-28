// GENERATED AUTOMATICALLY FROM 'Assets/Player1Input.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Player1Input : IInputActionCollection, IDisposable
{
    private InputActionAsset asset;
    public @Player1Input()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player1Input"",
    ""maps"": [
        {
            ""name"": ""Player1"",
            ""id"": ""d081d180-5ac1-4640-9a52-ab9723f57090"",
            ""actions"": [
                {
                    ""name"": ""Horizontal"",
                    ""type"": ""Value"",
                    ""id"": ""98c2bae6-37fe-4bd0-ba53-676563a0592e"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Vertical"",
                    ""type"": ""Value"",
                    ""id"": ""2a7dd76b-092d-47c2-8778-8cf0d2c01886"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Horizontal2"",
                    ""type"": ""Value"",
                    ""id"": ""0f77ccba-3086-48c4-b1b3-6c9a7a2163d6"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Vertical2"",
                    ""type"": ""Value"",
                    ""id"": ""063213b2-5248-482a-aeb2-1e39f931fd32"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Boost"",
                    ""type"": ""Value"",
                    ""id"": ""da9315b0-cac6-4a3b-a034-6f4f9ebc8980"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Warp"",
                    ""type"": ""Button"",
                    ""id"": ""42c185e1-1b53-4359-9f6a-7fe8008c8c84"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Break"",
                    ""type"": ""Button"",
                    ""id"": ""15e57a86-e1bd-4588-9c86-f58f00f87b03"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LockOn"",
                    ""type"": ""Button"",
                    ""id"": ""b7d2664c-c0d2-4e4b-8c26-3d1f35e618ce"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Button"",
                    ""id"": ""16e5e0a3-9a47-4278-9321-7326bbb76ab2"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Plus"",
                    ""type"": ""Button"",
                    ""id"": ""ffe91469-dd4c-43f8-8e16-57a8ce2da983"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Minus"",
                    ""type"": ""Button"",
                    ""id"": ""e0488a8f-5d45-4271-83e1-cb1c4e64221e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a4fcdf80-e7c3-4476-81cd-3daecb426d24"",
                    ""path"": ""<XInputController>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b92c6060-d435-46f5-bee7-79d46cf341c9"",
                    ""path"": ""<XInputController>/leftStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""75d61fb6-81da-4fb5-ace5-ca114d5ac86c"",
                    ""path"": ""<XInputController>/rightStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1e3f970f-f9d7-4ddc-a186-07c750079cc4"",
                    ""path"": ""<XInputController>/rightStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Vertical2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""32e2c32d-d0a7-484a-aee2-a5dae8be62e1"",
                    ""path"": ""<XInputController>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Boost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""327db392-41d0-4ba5-9656-1e69211dbb4d"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Warp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""944fddc8-6a8b-474e-a70c-26b539d02378"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Break"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b13468dc-c011-4615-a11a-26c6846fdd1c"",
                    ""path"": ""<XInputController>/leftShoulder"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LockOn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6619cf4e-bf0e-46fa-830d-7df34284932c"",
                    ""path"": ""<XInputController>/rightShoulder"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d49b102f-1af3-48b6-99df-bd92decac49a"",
                    ""path"": ""<XInputController>/dpad/up"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Plus"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""08724ce4-022e-44ef-8ad6-5b28aad985ba"",
                    ""path"": ""<XInputController>/dpad/down"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Minus"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player1
        m_Player1 = asset.FindActionMap("Player1", throwIfNotFound: true);
        m_Player1_Horizontal = m_Player1.FindAction("Horizontal", throwIfNotFound: true);
        m_Player1_Vertical = m_Player1.FindAction("Vertical", throwIfNotFound: true);
        m_Player1_Horizontal2 = m_Player1.FindAction("Horizontal2", throwIfNotFound: true);
        m_Player1_Vertical2 = m_Player1.FindAction("Vertical2", throwIfNotFound: true);
        m_Player1_Boost = m_Player1.FindAction("Boost", throwIfNotFound: true);
        m_Player1_Warp = m_Player1.FindAction("Warp", throwIfNotFound: true);
        m_Player1_Break = m_Player1.FindAction("Break", throwIfNotFound: true);
        m_Player1_LockOn = m_Player1.FindAction("LockOn", throwIfNotFound: true);
        m_Player1_Look = m_Player1.FindAction("Look", throwIfNotFound: true);
        m_Player1_Plus = m_Player1.FindAction("Plus", throwIfNotFound: true);
        m_Player1_Minus = m_Player1.FindAction("Minus", throwIfNotFound: true);
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

    // Player1
    private readonly InputActionMap m_Player1;
    private IPlayer1Actions m_Player1ActionsCallbackInterface;
    private readonly InputAction m_Player1_Horizontal;
    private readonly InputAction m_Player1_Vertical;
    private readonly InputAction m_Player1_Horizontal2;
    private readonly InputAction m_Player1_Vertical2;
    private readonly InputAction m_Player1_Boost;
    private readonly InputAction m_Player1_Warp;
    private readonly InputAction m_Player1_Break;
    private readonly InputAction m_Player1_LockOn;
    private readonly InputAction m_Player1_Look;
    private readonly InputAction m_Player1_Plus;
    private readonly InputAction m_Player1_Minus;
    public struct Player1Actions
    {
        private @Player1Input m_Wrapper;
        public Player1Actions(@Player1Input wrapper) { m_Wrapper = wrapper; }
        public InputAction @Horizontal => m_Wrapper.m_Player1_Horizontal;
        public InputAction @Vertical => m_Wrapper.m_Player1_Vertical;
        public InputAction @Horizontal2 => m_Wrapper.m_Player1_Horizontal2;
        public InputAction @Vertical2 => m_Wrapper.m_Player1_Vertical2;
        public InputAction @Boost => m_Wrapper.m_Player1_Boost;
        public InputAction @Warp => m_Wrapper.m_Player1_Warp;
        public InputAction @Break => m_Wrapper.m_Player1_Break;
        public InputAction @LockOn => m_Wrapper.m_Player1_LockOn;
        public InputAction @Look => m_Wrapper.m_Player1_Look;
        public InputAction @Plus => m_Wrapper.m_Player1_Plus;
        public InputAction @Minus => m_Wrapper.m_Player1_Minus;
        public InputActionMap Get() { return m_Wrapper.m_Player1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Player1Actions set) { return set.Get(); }
        public void SetCallbacks(IPlayer1Actions instance)
        {
            if (m_Wrapper.m_Player1ActionsCallbackInterface != null)
            {
                @Horizontal.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnHorizontal;
                @Horizontal.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnHorizontal;
                @Horizontal.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnHorizontal;
                @Vertical.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnVertical;
                @Vertical.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnVertical;
                @Vertical.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnVertical;
                @Horizontal2.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnHorizontal2;
                @Horizontal2.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnHorizontal2;
                @Horizontal2.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnHorizontal2;
                @Vertical2.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnVertical2;
                @Vertical2.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnVertical2;
                @Vertical2.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnVertical2;
                @Boost.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnBoost;
                @Boost.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnBoost;
                @Boost.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnBoost;
                @Warp.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnWarp;
                @Warp.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnWarp;
                @Warp.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnWarp;
                @Break.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnBreak;
                @Break.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnBreak;
                @Break.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnBreak;
                @LockOn.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnLockOn;
                @LockOn.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnLockOn;
                @LockOn.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnLockOn;
                @Look.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnLook;
                @Plus.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnPlus;
                @Plus.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnPlus;
                @Plus.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnPlus;
                @Minus.started -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMinus;
                @Minus.performed -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMinus;
                @Minus.canceled -= m_Wrapper.m_Player1ActionsCallbackInterface.OnMinus;
            }
            m_Wrapper.m_Player1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Horizontal.started += instance.OnHorizontal;
                @Horizontal.performed += instance.OnHorizontal;
                @Horizontal.canceled += instance.OnHorizontal;
                @Vertical.started += instance.OnVertical;
                @Vertical.performed += instance.OnVertical;
                @Vertical.canceled += instance.OnVertical;
                @Horizontal2.started += instance.OnHorizontal2;
                @Horizontal2.performed += instance.OnHorizontal2;
                @Horizontal2.canceled += instance.OnHorizontal2;
                @Vertical2.started += instance.OnVertical2;
                @Vertical2.performed += instance.OnVertical2;
                @Vertical2.canceled += instance.OnVertical2;
                @Boost.started += instance.OnBoost;
                @Boost.performed += instance.OnBoost;
                @Boost.canceled += instance.OnBoost;
                @Warp.started += instance.OnWarp;
                @Warp.performed += instance.OnWarp;
                @Warp.canceled += instance.OnWarp;
                @Break.started += instance.OnBreak;
                @Break.performed += instance.OnBreak;
                @Break.canceled += instance.OnBreak;
                @LockOn.started += instance.OnLockOn;
                @LockOn.performed += instance.OnLockOn;
                @LockOn.canceled += instance.OnLockOn;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Plus.started += instance.OnPlus;
                @Plus.performed += instance.OnPlus;
                @Plus.canceled += instance.OnPlus;
                @Minus.started += instance.OnMinus;
                @Minus.performed += instance.OnMinus;
                @Minus.canceled += instance.OnMinus;
            }
        }
    }
    public Player1Actions @Player1 => new Player1Actions(this);
    public interface IPlayer1Actions
    {
        void OnHorizontal(InputAction.CallbackContext context);
        void OnVertical(InputAction.CallbackContext context);
        void OnHorizontal2(InputAction.CallbackContext context);
        void OnVertical2(InputAction.CallbackContext context);
        void OnBoost(InputAction.CallbackContext context);
        void OnWarp(InputAction.CallbackContext context);
        void OnBreak(InputAction.CallbackContext context);
        void OnLockOn(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnPlus(InputAction.CallbackContext context);
        void OnMinus(InputAction.CallbackContext context);
    }
}
