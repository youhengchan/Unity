using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : StarBase
{
    public GameObject rotateCenterObject;
    public Vector3 pubRotateNormalAngle; 
    public float pubRotateAngularVelocity;
    void Start()
    {
        // Initialize the Self Rotation Tilt Angle first
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        base.Update();
        // Spin the object around the world origin at pubRotateAngularVelocity degrees/second.
        star.transform.RotateAround(rotateCenterObject.transform.position, pubRotateNormalAngle, pubRotateAngularVelocity * Time.deltaTime);
    }
}
