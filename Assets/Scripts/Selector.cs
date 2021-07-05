using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Selector : MonoBehaviour
{
    // PlayerActions playerActions;
    private CameraController camco;
    private Camera cam;
    public static Selector instance;



    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        camco = GameObject.Find("CameraAnchor").GetComponent<CameraController>();
        cam = Camera.main;
    }

    public Vector3 GetCurTilePosition()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return new Vector3(0, -99, 0); // if over UI move out the way


        Plane plane = new Plane(Vector3.up, Vector3.zero);
        Ray ray = cam.ScreenPointToRay(camco.mousePosPlacement);

        float rayOut = 0.0f;

        if (plane.Raycast(ray, out rayOut))
        {
            Vector3 newPos = ray.GetPoint(rayOut);
            newPos = new Vector3(Mathf.CeilToInt(newPos.x), 0.0f, Mathf.CeilToInt(newPos.z));
            return newPos;

        }

        return new Vector3(0, -99, 0);
    }
}
