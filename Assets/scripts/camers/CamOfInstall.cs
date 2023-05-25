using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using static UnityEngine.GraphicsBuffer;

public class CamOfInstall : MonoBehaviour
{
    bool ColbH2O = false;
    bool ColbH2SO4 = false;
    bool balon = false;

    public H2OController H2OController;
    public H2SO4Controller  H2SO4Controller;
    public NatryiCorbonController NatryiCorbonController;
    public usingBalon usingBalon;
    public TableController tableController;
    public BubbleGeneration bubbleGeneration;

    public GameObject informateBlock;
    public GameObject workBlock;
    public GameObject actionsBlock;
    public Text workText;
    public Text actionsText;

    public GameObject mainCam;
    public GameObject secondCam;

    private float smeshValue;
    public Material smesh;

    public Transform smeshPositon;
    public Transform setPositionOfSmesh;
    public Transform outPositionOfSmash;

    private float firstSubstance = -0.02f;
    private float secondSubstance = 0.01f;
    private bool firstSub = false;
    private bool secondSub = false;
    private bool canFilling = true;
    string firstObject;
    string secondObject;

    string objectToAdd;

    public ParticleSystem smokeEffect;
    public ParticleSystem fireEffect;

    private float setTime = 10f;
    private bool writeInTable = true;

    Color defaultColor;
    Color darkBlueColor;

    private void Start()
    {
        informateBlock.SetActive(false);
        ColbH2O = false;
        ColbH2SO4 = false;
        firstSub = true;
        secondSub = true;
        canFilling = true;
        writeInTable = true;

        
        ColorUtility.TryParseHtmlString("#003DFF", out defaultColor);
        ColorUtility.TryParseHtmlString("#0a0b47", out darkBlueColor);

        smesh.SetColor("_LiquidColor", defaultColor);
        smesh.SetColor("_SurfColor", defaultColor);
        smesh.SetColor("_FranchColor", defaultColor);

        smeshValue = -0.045f;
        smesh.SetFloat("_Fill", smeshValue);
    }
    private void Update()
    {
        if (canFilling)
        {
            switch (objectToAdd)
            {
                case "H2O":
                    {
                        if (ColbH2O && (secondSub || firstSub))
                        {
                            H2OController.ChangePositionToSmeshAndAddSubstance();
                            if (smesh.GetFloat("_Fill") >= firstSubstance && firstSub && secondSub)
                            {
                                firstSub = false;
                                ColbH2O = false;
                                firstObject = "H2O";
                            }
                            if (smesh.GetFloat("_Fill") >= secondSubstance && secondSub)
                            {
                                secondSub = false;
                                ColbH2O = false;
                                secondObject = "H2O";
                            }
                        }
                        else
                            H2OController.ChangePositionOnH2OToStratPosition();

                        break;
                    }
                case "H2SO4":
                    {
                 
                        if (ColbH2SO4 && (secondSub || firstSub))
                        {
                            H2SO4Controller.ChangePositionToSmeshAndAddSubstance();
                            if (smesh.GetFloat("_Fill") >= firstSubstance && firstSub && secondSub)
                            {
                                firstSub= false;
                                ColbH2SO4 = false;
                                firstObject = "H2SO4";
                            }
                            if (smesh.GetFloat("_Fill") >= secondSubstance && secondSub)
                            {
                                ColbH2SO4 = false;
                                secondSub = false;
                                secondObject = "H2SO4";
                            }
                        }
                        else
                            H2SO4Controller.ChangePositionOnH2SO4ToStratPosition();

                        break;
                    }
                case "Na":
                    {
                        if (secondSub || firstSub)
                        {
                            if (NatryiCorbonController.canDoNext)
                            {
                                if (firstSub)
                                {
                                    firstObject = "Na";
                                    firstSub = false;
                                    objectToAdd = null;
                                    NatryiCorbonController.canDoNext = false;
                                    break;
                                }
                                if (secondSub)
                                {
                                    secondObject = "Na";
                                    secondSub = false;
                                    NatryiCorbonController.canDoNext = false;
                                    objectToAdd = null;
                                }

                            }
                        }   
                        break;
                    }
                case "C":
                    {
                        if (secondSub || firstSub)
                        {
                            if (NatryiCorbonController.canDoNext)
                            {
                                if (firstSub)
                                {
                                    firstObject = "C";
                                    firstSub = false;
                                    objectToAdd = null;
                                    NatryiCorbonController.canDoNext = false;
                                    break;
                                }
                                if (secondSub)
                                {
                                    secondObject = "C";
                                    secondSub = false;
                                    NatryiCorbonController.canDoNext = false;
                                    objectToAdd = null;
                                    
                                }

                            }
                        }
                        break;
                    }
            }
        }
        else
        {
            H2OController.ChangePositionOnH2OToStratPosition();
            H2SO4Controller.ChangePositionOnH2SO4ToStratPosition();
        }
        if (!secondSub && !firstSub)
        {
           canFilling = false;
           CheckObjectsAddToSmesh();
        }
        else
        {
            canFilling = true;
            smeshPositon.position = Vector3.Lerp(smeshPositon.position, setPositionOfSmesh.position, 1f * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            mainCam.SetActive(true);
            secondCam.SetActive(false);
        }
    }

    public void onClickH2O()
    {
        if (secondSub || firstSub)
        {
            ColbH2O = !ColbH2O;
            objectToAdd = "H2O";
        }
        else
            actionsText.text = "Колба заполнена";
    }
    public void onClickH2SO4()
    {
        if (secondSub || firstSub)
        {
            ColbH2SO4 = !ColbH2SO4;
            objectToAdd = "H2SO4";
        }
        else
            actionsText.text = "Колба заполнена";
    }
    public void onClickNatryi()
    {
        if (secondSub || firstSub)
        {
            objectToAdd = "Na";
            NatryiCorbonController.ChangePositionNatryi();
        }
        else
            actionsText.text = "Колба заполнена";
    }
    public void onClickCorbon()
    {
        if (secondSub || firstSub)
        {
            objectToAdd = "C";
            NatryiCorbonController.ChangePositionCorbon();
        }
        else
            actionsText.text = "Колба заполнена";
    }
    public void onClickBalon()
    {
        usingBalon.turnOnVentel();
        balon = !balon;
    }

    void CheckObjectsAddToSmesh()
    {
        if (writeInTable)
        {
            if (firstObject.Equals("H2O") && secondObject.Equals("H2SO4")
               || firstObject.Equals("H2SO4") && secondObject.Equals("H2O"))
            {
                //h2o + h2so4
                smokeEffect.Play();
                bubbleGeneration.StartCoroutine("CreateBubble");
                tableController.InputData("H2O", "H2SO4", "H3O + HSO4");
            }
            else if (firstObject.Equals("H2O") && secondObject.Equals("C")
               || firstObject.Equals("C") && secondObject.Equals("H2O"))
            {
                //h2o + CARBON
                smokeEffect.Play();
                fireEffect.Play();
                smesh.SetColor("_LiquidColor", Color.black);
                smesh.SetColor("_SurfColor", Color.black);
                smesh.SetColor("_FranchColor", Color.black);
                tableController.InputData("H2O", "C", "CO+H2");
            }
            else if (firstObject.Equals("H2O") && secondObject.Equals("Na")
               || firstObject.Equals("Na") && secondObject.Equals("H2O"))
            {
                //h2o + NATRYI
                smokeEffect.Play();
                fireEffect.Play();
                tableController.InputData("H2O", "Na", "NaOH+H2");
            }

            else if (firstObject.Equals("H2SO4") && secondObject.Equals("C")
               || firstObject.Equals("C") && secondObject.Equals("H2SO4"))
            {
                //h2so4 + CARBON
                smesh.SetColor("_LiquidColor", Color.black);
                smesh.SetColor("_SurfColor", Color.black);
                smesh.SetColor("_FranchColor", Color.black);
                if(balon)
                    bubbleGeneration.StartCoroutine("CreateBubble");

                tableController.InputData("H2SO4", "C", "H2O+CO2+SO2");
            }
            else if (firstObject.Equals("H2SO4") && secondObject.Equals("Na")
               || firstObject.Equals("Na") && secondObject.Equals("H2SO4"))
            {
                //h2so4 + NATRYI
                smokeEffect.Play();
                fireEffect.Play();
                smesh.SetColor("_LiquidColor", darkBlueColor);
                smesh.SetColor("_SurfColor", darkBlueColor);
                smesh.SetColor("_FranchColor", darkBlueColor);
                tableController.InputData("H2SO4", "Na", "Na2SO4+H2");
            }

            else if (firstObject.Equals("C") && secondObject.Equals("Na")
               || firstObject.Equals("Na") && secondObject.Equals("C"))
            {
                //carbon + NATRYI
                tableController.InputData("Na", "C", "-");
            }

            actionsText.text = "Колба заполнена \n" +
                "Данные занесены в таблицу";
        }

        if (setTime<=0)
        {
            
            smokeEffect.Stop();
            fireEffect.Stop();
            NatryiCorbonController.DeleteNatryi();
            NatryiCorbonController.DeleteCorbon();

            smeshPositon.position = Vector3.Lerp(smeshPositon.position, outPositionOfSmash.position, 1f * Time.deltaTime);
            if (Vector3.Distance(smeshPositon.position, outPositionOfSmash.position) < 0.01)
            {
                smeshValue = -0.045f;
                smesh.SetFloat("_Fill", smeshValue);
                firstSub = true;
                secondSub = true;    
                H2OController.resetColb();
                H2SO4Controller.resetColb();
                writeInTable = true;
                setTime = 10f;

                smesh.SetColor("_LiquidColor", defaultColor);
                smesh.SetColor("_SurfColor", defaultColor);
                smesh.SetColor("_FranchColor", defaultColor);
                actionsText.text = "Колба очищена \n" +
                "Добавьте в колбу вещества";
            }
        }
        else
        {
            setTime -= Time.deltaTime;
            writeInTable = false;
        }
    }


    int count1=0;
    int count2=0;
    public void ShowHideInformation()
    {
        count1++;
        if(count1 == 1)
            informateBlock.SetActive(true); 
        else if(count1 == 2)
        {
            informateBlock.SetActive(false); 
            count1 = 0;
        }
           
    }
    public void ShowHideWork()
    {
        count2++;
        if (count2 == 1)
            workBlock.SetActive(true);
        else if (count2 == 2)
        {
            workBlock.SetActive(false);
            actionsBlock.SetActive(false);
            count2 = 0;
        }
    }

    public void work1()
    {
        tableController.workInInstaller = "work_1";
        actionsBlock.SetActive(true);
    }
    public void work2()
    {
        tableController.workInInstaller = "work_2";
        actionsBlock.SetActive(true);
    }
    public void work3()
    {
        tableController.workInInstaller = "work_3";
        actionsBlock.SetActive(true);
    }
    public void work4()
    {
        tableController.workInInstaller = "work_4";
        actionsBlock.SetActive(true);
    }
}
