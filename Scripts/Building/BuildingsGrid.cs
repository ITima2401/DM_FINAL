using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingsGrid : MonoBehaviour
{
    public Vector2Int GridSize = new Vector2Int(10, 10);
    private Building[,] grid;
    private Building flyingBuilding;
    private Camera mainCamera;
    public int priseMet;
    public int priseWd;
    public int priseHn;
    public bool StartPlacing;

    private void Awake()
    {
        grid = new Building[GridSize.x, GridSize.y];

        mainCamera = Camera.main;
    }

    public void StartPlacingBuilding(Building buildingPrefab)
    {
        
            if (flyingBuilding != null)
            {
                Destroy(flyingBuilding.gameObject);
            }

            flyingBuilding = Instantiate(buildingPrefab);

    }

    private void Update()
    {

        if (flyingBuilding != null)
        {
            
            var groundPlane = new Plane(Vector3.up, Vector3.zero);
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

            if (groundPlane.Raycast(ray, out float position))
            {
                Vector3 worldPosition = ray.GetPoint(position);

                int x = Mathf.RoundToInt(worldPosition.x);
                int y = Mathf.RoundToInt(worldPosition.z);
                
                bool available = true;

                if (x < 0 || x > GridSize.x - flyingBuilding.Size.x) available = false; 
                if (y < 0 || y > GridSize.y - flyingBuilding.Size.y) available = false; 
                
                if (available && IsPlaceTaken(x, y)) available = false;

                flyingBuilding.transform.position = new Vector3(x, 0, y);

                if (available && Input.GetMouseButtonDown(0))
                {
                    PlaceFlyingBuilding(x, y);
                    
                }
            }
        }
    }


    private bool IsPlaceTaken(int placeX, int placeY)
    {
        for (int x = 0; x < flyingBuilding.Size.x; x++)
        {
            for (int y = 0; y < flyingBuilding.Size.y; y++)
            {
                if (grid[placeX + x, placeY + y] != null) return true;
            }
        }

        return false;
    }

    private void PlaceFlyingBuilding(int placeX, int placeY)
    {
        for (int x = 0; x < flyingBuilding.Size.x; x++)
        {
            for (int y = 0; y < flyingBuilding.Size.y; y++)
            {
                grid[placeX + x, placeY + y] = flyingBuilding;
            }
        }
        GameObject.Find("Resources").GetComponent<ResourcesScript>().metall += -priseMet;
        GameObject.Find("Resources").GetComponent<ResourcesScript>().wood += -priseWd;
        GameObject.Find("Resources").GetComponent<ResourcesScript>().houney += -priseHn;
        flyingBuilding = null;
        
    }

    public void Delete()
    {
        if (flyingBuilding != null)
        {
            Destroy(flyingBuilding.gameObject);
        }
    }
}
