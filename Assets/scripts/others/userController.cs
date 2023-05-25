using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class userController : MonoBehaviour
{

    public GameObject mainCam;
    public GameObject secondCam;
    bool canSwitch = false;
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        
    }
    void Update()
    {
        float MoveX = Input.GetAxis("Horizontal");
        float MoveY = Input.GetAxis("Vertical");

        float MouseX = Input.GetAxis("Mouse X");
        
        transform.Rotate(0,0, MouseX);

        transform.Translate(0, MoveY *  Time.deltaTime,0);
        transform.Translate( -MoveX  * Time.deltaTime,0, 0);

        if (MoveX!=0 || MoveY!=0)
        {
            GetComponent<Animator>().Play("walk");
        }
        if (Input.GetKeyDown(KeyCode.Space) && canSwitch)
        {
            canSwitch = false;
            secondCam.SetActive(true);
            mainCam.SetActive(false);

        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "TriggerForInstaller")
        {
            canSwitch = true;
        }
    }
}
