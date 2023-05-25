using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubblesController : MonoBehaviour
{
    void Update()
    {
        if (transform.position.y < 0.31f)
            transform.Translate(Vector3.up * 0.04f * Time.deltaTime, Space.World);
        else
            Destroed();
    }

    public void Destroed()
    {
        Destroy(gameObject);
    }

}
