using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public GameObject ColbH20;
    public GameObject ColbH2SO4;
    public GameObject Natriy;  
    public GameObject Corbon;
    public GameObject Gorelka;
    public GameObject Smesh;
    public GameObject Balon;

    public Material DefaultColor;
    public Material GorelkaMaterial;

    public GameObject Camera;
    public GameObject CamPosition;
    public GameObject H2OPosition;
    public GameObject H2SO4Position;
    public GameObject NatryiPosition;
    public GameObject CorbonPosition;
    public GameObject GorelkaPosition;
    public GameObject SmeshPosition;
    public GameObject BalonPosition;

    bool canChangePosition;
    string objectToScroll;

    void Start()
    {
        canChangePosition=false;
    }

    void Update()
    {
        if(canChangePosition)
        {
            switch(objectToScroll)
            {
                case "H2O":
                    {
                        Camera.transform.position = Vector3.Lerp(Camera.transform.position, H2OPosition.transform.position, 2f * Time.deltaTime);
                        break;
                    }
                case "H2SO4":
                    {
                        Camera.transform.position = Vector3.Lerp(Camera.transform.position, H2SO4Position.transform.position, 2f * Time.deltaTime);
                        break;
                    }
                case "NATRYI":
                    {
                        Camera.transform.position = Vector3.Lerp(Camera.transform.position, NatryiPosition.transform.position, 2f * Time.deltaTime);
                        break;
                    }
                case "CORBON":
                    {
                        Camera.transform.position = Vector3.Lerp(Camera.transform.position, CorbonPosition.transform.position, 2f * Time.deltaTime);
                        break;
                    }
                case "GORELKA":
                    {
                        Camera.transform.position = Vector3.Lerp(Camera.transform.position, GorelkaPosition.transform.position, 2f * Time.deltaTime);
                        break;
                    }
                case "SMESH":
                    {
                        Camera.transform.position = Vector3.Lerp(Camera.transform.position, SmeshPosition.transform.position, 2f * Time.deltaTime);
                        break;
                    }
                case "BALON":
                    {
                        Camera.transform.position = Vector3.Lerp(Camera.transform.position, BalonPosition.transform.position, 2f * Time.deltaTime);
                        break;
                    }
            }
        }else
            Camera.transform.position = Vector3.Lerp(Camera.transform.position, CamPosition.transform.position, 2f * Time.deltaTime);
    }

    public void ChangeColorH20()
    {
        ColbH20.GetComponent<Renderer>().material.color = Color.red;
    }
    public void ChangeColorH20Back()
    {
        ColbH20.GetComponent<Renderer>().material = DefaultColor;
    }
    public void ClickH2O()
    {
        canChangePosition = !canChangePosition;
        objectToScroll = "H2O";
    }

    public void ChangeColorH2SH4()
    {
        ColbH2SO4.GetComponent<Renderer>().material.color = Color.red;
    }
    public void ChangeColorH2SO4Back()
    {
        ColbH2SO4.GetComponent<Renderer>().material = DefaultColor;
    }
    public void ClickH2SO4()
    {
        canChangePosition = !canChangePosition;
        objectToScroll = "H2SO4";
    }

    public void ChangeColorNatryi()
    {
        Natriy.GetComponent<Renderer>().material.color = Color.red;
    }
    public void ChangeColorNatryiBack()
    {
        Natriy.GetComponent<Renderer>().material = DefaultColor;
    }
    public void ClickNatryi()
    {
        canChangePosition = !canChangePosition;
        objectToScroll = "NATRYI";
    }

    public void ChangeColorCorbon()
    {
        Corbon.GetComponent<Renderer>().material.color = Color.red;
    }
    public void ChangeColorCorbomBack()
    {
        Corbon.GetComponent<Renderer>().material = DefaultColor;
    }
    public void ClickCorbon()
    {
        canChangePosition = !canChangePosition;
        objectToScroll = "CORBON";
    }

    public void ChangeColorGorelka()
    {
        Gorelka.GetComponent<Renderer>().material.color = Color.red;
    }
    public void ChangeColorGorelkaBack()
    {
        Gorelka.GetComponent<Renderer>().material = GorelkaMaterial;
    }
    public void ClickGorelka()
    {
        canChangePosition = !canChangePosition;
        objectToScroll = "GORELKA";
    }

    public void ChangeColorSmesh()
    {
        Smesh.GetComponent<Renderer>().material.color = Color.red;
    }
    public void ChangeColorSmeshBack()
    {
        Smesh.GetComponent<Renderer>().material = DefaultColor;
    }
    public void ClickSmesh()
    {
        canChangePosition = !canChangePosition;
        objectToScroll = "SMESH";
    }

    public void ChangeColorBalon()
    {
        Balon.GetComponent<Renderer>().material.color = Color.red;
    }
    public void ChangeColorBalonBack()
    {
        Balon.GetComponent<Renderer>().material.color = Color.grey;
    }
    public void ClickBalon()
    {
        canChangePosition = !canChangePosition;
        objectToScroll = "BALON";
    }
}
