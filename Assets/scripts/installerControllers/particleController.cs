using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particleController : MonoBehaviour
{
    public GameObject target;
    void Update()
    {
        transform.LookAt(target.transform);   
    }
}
