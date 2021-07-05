using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingPlacement : MonoBehaviour
{
    private CameraController cameraCo;
    private bool currentlyPlacing;
    private bool currentlyBulldozering;
    private int currentC;
    private Vector3 curPlaceOffset = new Vector3(0.5f, 0f, 0f);
    private Vector3 curPlaceRotateOffset = new Vector3(0f, 0f, 0.5f);
    private Vector3 curPlaceNextTo = new Vector3(1f, 0f, 0f);

    private BuildingPreset curBuildingPreset;

    private float indicatorUpdateRate = 0.05f;
    private float lastUpdateTime;
    private int presses;
    private Vector3 curIndicatorPos;

    public GameObject placementIndicator;
    public GameObject bulldozeIndicator;

    public List<Vector3> placeLocations = new List<Vector3>();
    public GameObject buildingGhost;

    private City city;

    void Start()
    {
        city = GetComponent<City>();
        cameraCo = GameObject.Find("CameraAnchor").GetComponent<CameraController>();
    }

    void Update()
    {
        if (cameraCo.cancelPressed)
            CancelBuildingPlacement();

        if (Time.time - lastUpdateTime > indicatorUpdateRate)
        {
            lastUpdateTime = Time.time;
            curIndicatorPos = Selector.instance.GetCurTilePosition();

            if (currentlyPlacing) {
                placementIndicator.transform.position = curIndicatorPos;
                placementIndicator.transform.GetChild(currentC).localRotation = Quaternion.Euler(new Vector3(0, cameraCo.rotatePlacementPressed * 90, 0));
            }
            else if (currentlyBulldozering)
                bulldozeIndicator.transform.position = curIndicatorPos;

            if (cameraCo.placeBuildingDown && currentlyPlacing)
                PlaceBuilding();
            else if (cameraCo.placeBuildingDown && currentlyBulldozering)
                Bulldoze();
        }
    }



        public void BeginNewBuildingPlacement(BuildingPreset preset)
        {
            curBuildingPreset = preset;

            if (city.money >= curBuildingPreset.cost)
            {
                currentlyPlacing = true;
                placementIndicator.SetActive(true);

                switch(curBuildingPreset.name) {
                    case "Farm":
                        currentC = 1;
                        placementIndicator.transform.GetChild(1).gameObject.SetActive(true); 
                        placementIndicator.transform.position = new Vector3(0, -99, 0);
                        break;
                    case "House":
                        currentC = 2;
                        placementIndicator.transform.GetChild(2).gameObject.SetActive(true); 
                        placementIndicator.transform.position = new Vector3(0, -99, 0);
                        break;
                    case "Factory":
                        currentC = 3;
                        placementIndicator.transform.GetChild(3).gameObject.SetActive(true); 
                        placementIndicator.transform.position = new Vector3(0, -99, 0);
                        break;
                    case "Cinema":
                        currentC = 4;
                        placementIndicator.transform.GetChild(4).gameObject.SetActive(true); 
                        placementIndicator.transform.position = new Vector3(0, -99, 0);
                        break;
                    case "BigBuilding":
                        currentC = 5;
                        placementIndicator.transform.GetChild(5).gameObject.SetActive(true); 
                        placementIndicator.transform.position = new Vector3(0, -99, 0);
                        break;
                    case "Road":
                        currentC = 6;
                        placementIndicator.transform.GetChild(6).gameObject.SetActive(true); 
                        placementIndicator.transform.position = new Vector3(0, -99, 0);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                return;
            }
        }

        void CancelBuildingPlacement()
        {
            currentlyPlacing = false;
            placementIndicator.SetActive(false);
            placementIndicator.transform.GetChild(currentC).gameObject.SetActive(false);
            currentC = 0;
        }

        public void ToggleBulldoze()
        {
            currentlyBulldozering = !currentlyBulldozering;
            bulldozeIndicator.SetActive(currentlyBulldozering);
            bulldozeIndicator.transform.position = new Vector3(0, -99, 0);
        }

        void PlaceBuilding()
        {
            if (!placeLocations.Contains(curIndicatorPos) && !curBuildingPreset.twosquare)
            {
                if (cameraCo.rotatePlacementPressed > 0) {
                    GameObject buildingObj = Instantiate(curBuildingPreset.prefab, curIndicatorPos, Quaternion.Euler(new Vector3(0, cameraCo.rotatePlacementPressed * 90, 0)));
                    City.instance.OnPlaceBuilding(buildingObj.GetComponent<Building>());
                    placeLocations.Add(curIndicatorPos);
                    cameraCo.rotatePlacementPressed = 0;
                }
                else {
                    GameObject buildingObj = Instantiate(curBuildingPreset.prefab, curIndicatorPos, Quaternion.identity);
                    City.instance.OnPlaceBuilding(buildingObj.GetComponent<Building>());
                    placeLocations.Add(curIndicatorPos);
                    cameraCo.rotatePlacementPressed = 0;
                }
            }


            else if (!placeLocations.Contains(curIndicatorPos) && !placeLocations.Contains(curIndicatorPos + curPlaceNextTo) && curBuildingPreset.twosquare)
            {
                if (cameraCo.rotatePlacementPressed % 4 != 0) {
                    GameObject buildingObj = Instantiate(curBuildingPreset.prefab, curIndicatorPos + curPlaceRotateOffset, Quaternion.Euler(new Vector3(0, cameraCo.rotatePlacementPressed * 90, 0)));
                    City.instance.OnPlaceBuilding(buildingObj.GetComponent<Building>());
                    placeLocations.Add(curIndicatorPos);
                    placeLocations.Add(curIndicatorPos + new Vector3(0f, 0f, 1f));
                    cameraCo.rotatePlacementPressed = 0;
                }
                else {
                    GameObject buildingObj = Instantiate(curBuildingPreset.prefab, curIndicatorPos + curPlaceOffset, Quaternion.Euler(new Vector3(0, cameraCo.rotatePlacementPressed * 90, 0)));
                    City.instance.OnPlaceBuilding(buildingObj.GetComponent<Building>());
                    placeLocations.Add(curIndicatorPos);
                    placeLocations.Add(curIndicatorPos + curPlaceNextTo);
                    cameraCo.rotatePlacementPressed = 0;
                }
            }


            if (curBuildingPreset.prefab.tag == "road")
                return;
            else
                CancelBuildingPlacement();

            currentC = 0;
        }

        void Bulldoze()
        {
            Building buildingToDestroy = City.instance.buildings.Find(x => x.transform.position == curIndicatorPos);
            if (buildingToDestroy != null)
            {
                City.instance.OnRemoveBuilding(buildingToDestroy);
            }
        }
}

