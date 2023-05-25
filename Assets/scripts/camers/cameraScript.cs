using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour
{ 
    float xRotation = 0f;
    void Update()
    {
        float MouseY = Input.GetAxis("Mouse Y");
        xRotation -= MouseY;
        xRotation = Mathf.Clamp(xRotation, -15, 25);

        transform.localRotation = Quaternion.Euler(xRotation, 180, 0);
    }
}
