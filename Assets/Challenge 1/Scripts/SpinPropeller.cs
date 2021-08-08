using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropeller : MonoBehaviour
{
    private Vector3 rotationAngle = new Vector3(0, 0, 1);
    private float rotationSpeed = 2000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationAngle, rotationSpeed * Time.deltaTime);
    }
}
