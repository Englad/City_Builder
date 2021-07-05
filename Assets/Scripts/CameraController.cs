using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    PlayerActions playerActions;
    public float mouseScrollY;
    public Vector2 mousePos;
    public Vector2 mousePosPlacement;
    private bool rmbPressed;
    public Vector2 input_Movement;
    public bool cancelPressed;
    public bool placeBuildingDown;
    public int rotatePlacementPressed;


    public float moveSpeed;

    public float minXRot;
    public float maxXRot;

    private float curXRot;

    public float minZoom;
    public float maxZoom;

    public float zoomSpeed;
    public float rotateSpeed;

    private float curZoom;
    private Camera cam;

    #region - Awake playerActions
    private void Awake()
    {
        playerActions = new PlayerActions();
        playerActions.PlayerControls.Zoom.performed += zoomUsed => mouseScrollY = zoomUsed.ReadValue<float>(); // log scroll wheel to X and Y
        playerActions.PlayerControls.RotateCamera.performed += rotateUsed => mousePos = rotateUsed.ReadValue<Vector2>(); // log the X and Y of mouse to Vector2
        playerActions.PlayerControls.Placement.performed += mousePlacement => mousePosPlacement = mousePlacement.ReadValue<Vector2>(); // logging mouse pos for placement
        playerActions.PlayerControls.RotateExtra.started += rotatePress => rmbPressed = true; // when right button is pressed set variable to true
        playerActions.PlayerControls.RotateExtra.canceled += rotatePress => rmbPressed = false; // when released set variable to false
        playerActions.PlayerControls.Movement.performed += x => input_Movement = x.ReadValue<Vector2>(); // WASD movement
        playerActions.PlayerControls.Cancel.started += cancelPress => cancelPressed = true; // when escape button is pressed set variable to true
        playerActions.PlayerControls.Cancel.canceled += cancelPress => cancelPressed = false; // when released set variable to false
        playerActions.PlayerControls.Placing.started += placeBuilding => placeBuildingDown = true; // when lmb button is pressed set variable to true
        playerActions.PlayerControls.Placing.canceled += placeBuilding => placeBuildingDown = false; 
        playerActions.PlayerControls.RotatePlacement.performed += rotatePlacement => rotatePlacementPressed++;
    }
    #endregion

    #region - Enable / Disable
    void OnEnable()
    {
        playerActions.Enable();
    }
    void OnDisable()
    {
        playerActions.Disable();
    }
    #endregion

    void Start()
    {
        cam = Camera.main;
        curZoom = cam.transform.localPosition.y;
        curXRot = -50;
    }

    void Update()
    {
        //zooming
        curZoom += mouseScrollY * -zoomSpeed;
        Mathf.Clamp(curZoom, minZoom, maxZoom);

        cam.transform.localPosition = Vector3.up * curZoom;

        //camera look
        if(rmbPressed) // if right mouse button is pressed
        {
            curXRot += -mousePos.y * rotateSpeed;
            curXRot = Mathf.Clamp(curXRot, minXRot, maxXRot);

            transform.eulerAngles = new Vector3(curXRot, transform.eulerAngles.y + (mousePos.x * rotateSpeed), 0.0f);
        }
        // wasd movement
        Vector3 forward = cam.transform.forward;
        forward.y = 0.0f;
        forward.Normalize();

        Vector3 right = cam.transform.right;

        Vector3 dir = forward * input_Movement.y + right * input_Movement.x;
        dir.Normalize();

        dir *= moveSpeed * Time.deltaTime;

        transform.position += dir;
    }
}
