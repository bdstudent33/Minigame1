using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentCamera : MonoBehaviour
{
    public GameObject player; 

    void Start()
    {
        // Set the camera's parent to the player
        transform.parent = player.transform;

      
        transform.localPosition = new Vector3(0, 5, -10);
        transform.localRotation = Quaternion.identity;
    }
}