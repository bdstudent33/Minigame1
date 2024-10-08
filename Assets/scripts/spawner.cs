using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleSpawner : MonoBehaviour
{
    public GameObject vehiclePrefab; 
    public Transform spawnPoint;

    private GameObject currentVehicle;

    private void Start()
    {
       
        SpawnVehicle();
    }

    private void Update()
    {
        
        if (currentVehicle == null)
        {
            
            SpawnVehicle();
        }
    }

    private void SpawnVehicle()
    {
        if (vehiclePrefab != null && spawnPoint != null)
        {
            
            currentVehicle = Instantiate(vehiclePrefab, spawnPoint.position, spawnPoint.rotation);
        }
        else
        {
            Debug.LogWarning("Vehicle prefab or spawn point not assigned in the inspector.");
        }
    }
}