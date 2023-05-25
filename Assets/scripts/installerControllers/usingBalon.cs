using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class usingBalon : MonoBehaviour
{
    public GameObject ventel;
    public bool turnOn;
    public void turnOnVentel ()
    {
        turnOn = !turnOn;
    }

    private void Update()
    {
        if(turnOn)
            ventel.transform.rotation = Quaternion.Lerp(ventel.transform.rotation, Quaternion.Euler(-90.0f, 0, 90.0f), Time.deltaTime * 5.0f);
        else
            ventel.transform.rotation = Quaternion.Lerp(ventel.transform.rotation, Quaternion.Euler(-90.0f, 0, 0), Time.deltaTime * 5.0f);
    }
}
