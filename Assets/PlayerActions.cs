// GENERATED AUTOMATICALLY FROM 'Assets/PlayerActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerActions"",
    ""maps"": [
        {
            ""name"": ""PlayerControls"",
            ""id"": ""239eee3a-e4a2-4a85-b96a-87d0cf4d2f1a"",
            ""actions"": [
                {
                    ""name"": ""Zoom"",
                    ""type"": ""PassThrough"",
                    ""id"": ""51ba1a89-7c92-47ef-9b87-49c373c1ddf6"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RotateCamera"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9ca5be35-b013-4664-8616-25a447a2ec66"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RotateExtra"",
                    ""type"": ""Button"",
                    ""id"": ""bcdbae3a-550f-4d77-8f35-f319c5a294f7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""7c4297f4-2877-440a-aa5d-43e3751202ed"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Placement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ad32655f-939f-4bea-a0c7-0b28a8fedcde"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""4d827240-5270-42b6-ac1a-2a7c94daf0b5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Placing"",
                    ""type"": ""Button"",
                    ""id"": ""967304e0-7fea-4d83-9ea6-c5d1e367d494"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RotatePlacement"",
                    ""type"": ""Value"",
                    ""id"": ""2d3c6fb8-d15b-4fd1-a429-43dc989c8172"",
                    ""expectedControlType"": ""Integer"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ed3142ab-696d-44ee-82e1-f228839ff65f"",
                    ""path"": ""<Mouse>/scroll/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dbbc8e7a-9e67-4a76-b639-e76add6feb69"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""RotateCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fd025b9b-5dfe-4291-aa90-adb915eb4086"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""RotateExtra"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""wasd"",
                    ""id"": ""e99f2889-9a9f-40c6-a7e3-446d95a734c1"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""fd15d878-cef1-4e6e-a12b-7dd6e6fa008e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ba6d6369-6d2f-4a73-96ce-30d4b4acd558"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""513e8860-f03c-402a-b814-bb046d851b68"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e9497225-56ac-4c49-8d54-672cde575b7b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b526f0b7-5be1-4984-8e60-2be0f3d08586"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Placement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9e621b65-59a9-4d9c-b093-e9f61a7a6610"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5240a896-4568-40cd-bbd5-0420ff7c319c"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Placing"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e77809dc-01f5-4a15-8363-c655337515aa"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""RotatePlacement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // PlayerControls
        m_PlayerControls = asset.FindActionMap("PlayerControls", throwIfNotFound: true);
        m_PlayerControls_Zoom = m_PlayerControls.FindAction("Zoom", throwIfNotFound: true);
        m_PlayerControls_RotateCamera = m_PlayerControls.FindAction("RotateCamera", throwIfNotFound: true);
        m_PlayerControls_RotateExtra = m_PlayerControls.FindAction("RotateExtra", throwIfNotFound: true);
        m_PlayerControls_Movement = m_PlayerControls.FindAction("Movement", throwIfNotFound: true);
        m_PlayerControls_Placement = m_PlayerControls.FindAction("Placement", throwIfNotFound: true);
        m_PlayerControls_Cancel = m_PlayerControls.FindAction("Cancel", throwIfNotFound: true);
        m_PlayerControls_Placing = m_PlayerControls.FindAction("Placing", throwIfNotFound: true);
        m_PlayerControls_RotatePlacement = m_PlayerControls.FindAction("RotatePlacement", throwIfNotFound: true);
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

    // PlayerControls
    private readonly InputActionMap m_PlayerControls;
    private IPlayerControlsActions m_PlayerControlsActionsCallbackInterface;
    private readonly InputAction m_PlayerControls_Zoom;
    private readonly InputAction m_PlayerControls_RotateCamera;
    private readonly InputAction m_PlayerControls_RotateExtra;
    private readonly InputAction m_PlayerControls_Movement;
    private readonly InputAction m_PlayerControls_Placement;
    private readonly InputAction m_PlayerControls_Cancel;
    private readonly InputAction m_PlayerControls_Placing;
    private readonly InputAction m_PlayerControls_RotatePlacement;
    public struct PlayerControlsActions
    {
        private @PlayerActions m_Wrapper;
        public PlayerControlsActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Zoom => m_Wrapper.m_PlayerControls_Zoom;
        public InputAction @RotateCamera => m_Wrapper.m_PlayerControls_RotateCamera;
        public InputAction @RotateExtra => m_Wrapper.m_PlayerControls_RotateExtra;
        public InputAction @Movement => m_Wrapper.m_PlayerControls_Movement;
        public InputAction @Placement => m_Wrapper.m_PlayerControls_Placement;
        public InputAction @Cancel => m_Wrapper.m_PlayerControls_Cancel;
        public InputAction @Placing => m_Wrapper.m_PlayerControls_Placing;
        public InputAction @RotatePlacement => m_Wrapper.m_PlayerControls_RotatePlacement;
        public InputActionMap Get() { return m_Wrapper.m_PlayerControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerControlsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerControlsActions instance)
        {
            if (m_Wrapper.m_PlayerControlsActionsCallbackInterface != null)
            {
                @Zoom.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnZoom;
                @Zoom.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnZoom;
                @Zoom.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnZoom;
                @RotateCamera.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRotateCamera;
                @RotateCamera.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRotateCamera;
                @RotateCamera.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRotateCamera;
                @RotateExtra.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRotateExtra;
                @RotateExtra.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRotateExtra;
                @RotateExtra.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRotateExtra;
                @Movement.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnMovement;
                @Placement.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPlacement;
                @Placement.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPlacement;
                @Placement.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPlacement;
                @Cancel.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnCancel;
                @Placing.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPlacing;
                @Placing.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPlacing;
                @Placing.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnPlacing;
                @RotatePlacement.started -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRotatePlacement;
                @RotatePlacement.performed -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRotatePlacement;
                @RotatePlacement.canceled -= m_Wrapper.m_PlayerControlsActionsCallbackInterface.OnRotatePlacement;
            }
            m_Wrapper.m_PlayerControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Zoom.started += instance.OnZoom;
                @Zoom.performed += instance.OnZoom;
                @Zoom.canceled += instance.OnZoom;
                @RotateCamera.started += instance.OnRotateCamera;
                @RotateCamera.performed += instance.OnRotateCamera;
                @RotateCamera.canceled += instance.OnRotateCamera;
                @RotateExtra.started += instance.OnRotateExtra;
                @RotateExtra.performed += instance.OnRotateExtra;
                @RotateExtra.canceled += instance.OnRotateExtra;
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Placement.started += instance.OnPlacement;
                @Placement.performed += instance.OnPlacement;
                @Placement.canceled += instance.OnPlacement;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
                @Placing.started += instance.OnPlacing;
                @Placing.performed += instance.OnPlacing;
                @Placing.canceled += instance.OnPlacing;
                @RotatePlacement.started += instance.OnRotatePlacement;
                @RotatePlacement.performed += instance.OnRotatePlacement;
                @RotatePlacement.canceled += instance.OnRotatePlacement;
            }
        }
    }
    public PlayerControlsActions @PlayerControls => new PlayerControlsActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    public interface IPlayerControlsActions
    {
        void OnZoom(InputAction.CallbackContext context);
        void OnRotateCamera(InputAction.CallbackContext context);
        void OnRotateExtra(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnPlacement(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
        void OnPlacing(InputAction.CallbackContext context);
        void OnRotatePlacement(InputAction.CallbackContext context);
    }
}
