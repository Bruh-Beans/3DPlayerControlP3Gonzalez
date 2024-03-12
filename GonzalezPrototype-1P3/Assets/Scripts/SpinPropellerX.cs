using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Make the propeller spin per frame
public class SpinPropellerX : MonoBehaviour
{
    private float propellorSpeed = 1000;
    void Start() { }
    void Update()
    {
        transform.Rotate(Vector3.forward, propellorSpeed * Time.deltaTime);
    }
}
