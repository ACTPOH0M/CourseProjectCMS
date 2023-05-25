using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class usingColbH2SO4 : MonoBehaviour
{
    public int pourThreshold = 45;
    private bool isPouring = false;
    public ParticleSystem mparticleSystem;

    void Update()
    {
        bool pourCheck = CalculatePourAngle() < pourThreshold;
        if (isPouring != pourCheck)
        {
            isPouring = pourCheck;
            if (isPouring)
                StartPour();
            else
                EndPour();
        }
    }
    private void StartPour()
    {
        mparticleSystem.Play();
    }
    private void EndPour()
    {
        mparticleSystem.Stop();
    }

    private float CalculatePourAngle()
    {
        return -transform.forward.y * Mathf.Rad2Deg;
    }
}
