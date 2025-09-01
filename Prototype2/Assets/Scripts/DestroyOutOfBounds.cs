using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float zUpperBound = 35;
    private float zLowerBound = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > zUpperBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < zLowerBound)
        {
            Destroy(gameObject);
        }
    }
}
