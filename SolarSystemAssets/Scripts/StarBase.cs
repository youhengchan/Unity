using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarBase : MonoBehaviour
{
    public GameObject star;
    public Vector3 selfRotateAngularVelocity;
    public Vector3 selfRotateTiltAngle;
    protected void Start()
    {
        // Initialize the Rotation of star refering to the world cordinates
        star.transform.eulerAngles = selfRotateTiltAngle;
        // For parental transformation : 
        // transform.localEulerAngles = new Vector3(arg1,arg2,arg3);
    }
    protected void SelfRotate()
    {
        star.transform.Rotate(selfRotateAngularVelocity, Space.Self);
    }

    // Update is called once per frame
    protected void Update()
    {
        SelfRotate();
        // Do nothing
    }
}
