using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    private float topBound = 20;
    private float lowerBound = -5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > topBound)
        {
            Destroy(gameObject);
        } else if (transform.position.y < lowerBound)
        {
            Destroy(gameObject);
        }
        
    }
}
