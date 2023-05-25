using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.Networking.UnityWebRequest;

public class TableController : MonoBehaviour
{
    public GameObject Table;
    //firstLine
    public Text firstSubFirstLine;
    public Text secondSubFirstLine;
    public Text resultFirstLine;
    public Text isTrueFirstLine;
    //secondLine
    public Text firstSubSecondLine;
    public Text secondSubSecondLine;
    public Text resultSecondLine;
    public Text isTrueSecondLine;
    //ThirdLine
    public Text firstSubThirdLine;
    public Text secondSubThirdLine;
    public Text resultThirdLine;
    public Text isTrueThirdLine;
    //FourthLine
    public Text firstSubFourthLine;
    public Text secondSubFourthLine;
    public Text resultFourthLine;
    public Text isTrueFourthLine;
    //FifththLine
    public Text firstSubFifthLine;
    public Text secondSubFifthLine;
    public Text resultFifthLine;
    public Text isTrueFifthLine;

    bool ShowHide;
    public string workInInstaller;
    string canInput;
    void Start()
    {
        ShowHide = false;
        canInput = null;
    }
    public void ShowHideTable()
    {
        ShowHide = !ShowHide;
        Table.SetActive(ShowHide);
    }
    public void InputData(string firstSub ,string secondSub,string result)
    {         
        if (string.IsNullOrEmpty(firstSubFirstLine.text))
        {
            firstSubFirstLine.text = firstSub;
            secondSubFirstLine.text = secondSub;
            resultFirstLine.text = result;
            canInput = "FIRSTLINE";
        }
        else if (string.IsNullOrEmpty(firstSubSecondLine.text))
        {
            firstSubSecondLine.text = firstSub;
            secondSubSecondLine.text = secondSub;
            resultSecondLine.text = result;
            canInput = "SECONDLINE";
        }
        else if (string.IsNullOrEmpty(firstSubThirdLine.text))
        {
            firstSubThirdLine.text = firstSub;
            secondSubThirdLine.text = secondSub;
            resultThirdLine.text = result; 
            canInput = "THIRDLINE";
        }
        else if (string.IsNullOrEmpty(firstSubFourthLine.text))
        {
            firstSubFourthLine.text = firstSub;
            secondSubFourthLine.text = secondSub;
            resultFourthLine.text = result;
            canInput = "FOURTHLINE";
        }
        else if (string.IsNullOrEmpty(firstSubFifthLine.text))
        {
            firstSubFourthLine.text = firstSub;
            secondSubFourthLine.text = secondSub;
            resultFifthLine.text = result;
            canInput = "FIFTHLINE";
        }
        else
        {
            ClearTable();
            canInput = null;
            InputData(firstSub, secondSub, result);
        }
        AnalitycsResult();
    }

    public void ClearTable()
    {
        firstSubFirstLine.text = null; 
        secondSubFirstLine.text = null;
        resultFirstLine.text = null;    
        isTrueFirstLine.text = null;

        firstSubSecondLine.text = null;
        secondSubSecondLine.text = null;
        resultSecondLine.text = null;
        isTrueSecondLine.text = null;

        firstSubThirdLine.text = null;
        secondSubThirdLine.text = null;
        resultThirdLine.text = null;
        isTrueThirdLine.text = null;

        firstSubFourthLine.text = null;
        secondSubFourthLine.text = null;
        resultFourthLine.text = null;
        isTrueFourthLine.text = null;

        firstSubFifthLine.text = null;
        secondSubFifthLine.text = null;
        resultFifthLine.text = null;
        isTrueFifthLine.text = null;
    }

    private void AnalitycsResult()
    {
        switch (workInInstaller)
        {
            case "work_1":
                {
                    switch (canInput)
                    {
                        case "FIRSTLINE":
                            {
                                if (firstSubFirstLine.text == "H2O" && secondSubFirstLine.text == "H2SO4"
                                || firstSubFirstLine.text == "H2SO4" && secondSubFirstLine.text == "H2O")
                                    isTrueFirstLine.text = "Задание выполнено";
                                else
                                    isTrueFirstLine.text = "Задание не выполнено";
                                break;
                            }
                        case "SECONDLINE":
                            {
                                if (firstSubSecondLine.text == "H2O" && secondSubSecondLine.text == "H2SO4"
                                || firstSubSecondLine.text == "H2SO4" && secondSubSecondLine.text == "H2O")
                                    isTrueSecondLine.text = "Задание выполнено";
                                else
                                    isTrueSecondLine.text = "Задание не выполнено";
                                break;
                            }
                        case "THIRDLINE":
                            {
                                if (firstSubThirdLine.text == "H2O" && secondSubThirdLine.text == "H2SO4"
                                || firstSubThirdLine.text == "H2SO4" && secondSubThirdLine.text == "H2O")
                                    isTrueThirdLine.text = "Задание выполнено";
                                else
                                    isTrueThirdLine.text = "Задание не выполнено";
                                break;
                            }
                        case "FOURTHLINE":
                            {
                                if (firstSubFourthLine.text == "H2O" && secondSubFourthLine.text == "H2SO4"
                                || firstSubFourthLine.text == "H2SO4" && secondSubFourthLine.text == "H2O")
                                    isTrueFourthLine.text = "Задание выполнено";
                                else
                                    isTrueFourthLine.text = "Задание не выполнено";
                                break;
                            }
                        case "FIFTHLINE":
                            {
                                if (firstSubFifthLine.text == "H2O" && secondSubFifthLine.text == "H2SO4"
                                || firstSubFifthLine.text == "H2SO4" && secondSubFifthLine.text == "H2O")
                                    isTrueFifthLine.text = "Задание выполнено";
                                else
                                    isTrueFifthLine.text = "Задание не выполнено";
                                break;
                            }
                    }
                    break;
            }
            case "work_2":
            {
                    switch (canInput)
                    {
                        case "FIRSTLINE":
                            {
                                if (firstSubFirstLine.text == "H2O" && secondSubFirstLine.text == "Na"
                                || firstSubFirstLine.text == "Na" && secondSubFirstLine.text == "H2O")
                                    isTrueFirstLine.text = "Задание выполнено";
                                else
                                    isTrueFirstLine.text = "Задание не выполнено";
                                break;
                            }
                        case "SECONDLINE":
                            {
                                if (firstSubSecondLine.text == "H2O" && secondSubSecondLine.text == "Na"
                                || firstSubSecondLine.text == "Na" && secondSubSecondLine.text == "H2O")
                                    isTrueSecondLine.text = "Задание выполнено";
                                else
                                    isTrueSecondLine.text = "Задание не выполнено";
                                break;
                            }
                        case "THIRDLINE":
                            {
                                if (firstSubThirdLine.text == "H2O" && secondSubThirdLine.text == "Na"
                                || firstSubThirdLine.text == "Na" && secondSubThirdLine.text == "H2O")
                                    isTrueThirdLine.text = "Задание выполнено";
                                else
                                    isTrueThirdLine.text = "Задание не выполнено";
                                break;
                            }
                        case "FOURTHLINE":
                            {
                                if (firstSubFourthLine.text == "H2O" && secondSubFourthLine.text == "Na"
                                || firstSubFourthLine.text == "Na" && secondSubFourthLine.text == "H2O")
                                    isTrueFourthLine.text = "Задание выполнено";
                                else
                                    isTrueFourthLine.text = "Задание не выполнено";
                                break;
                            }
                        case "FIFTHLINE":
                            {
                                if (firstSubFifthLine.text == "H2O" && secondSubFifthLine.text == "Na"
                                || firstSubFifthLine.text == "Na" && secondSubFifthLine.text == "H2O")
                                    isTrueFifthLine.text = "Задание выполнено";
                                else
                                    isTrueFifthLine.text = "Задание не выполнено";
                                break;
                            }
                    }
                    break;
            }
            case "work_3":
                {
                    switch (canInput)
                    {
                        case "FIRSTLINE":
                            {
                                if (firstSubFirstLine.text == "Na" && secondSubFirstLine.text == "H2SO4"
                                || firstSubFirstLine.text == "H2SO4" && secondSubFirstLine.text == "Na")
                                    isTrueFirstLine.text = "Задание выполнено";
                                else
                                    isTrueFirstLine.text = "Задание не выполнено";
                                break;
                            }
                        case "SECONDLINE":
                            {
                                if (firstSubSecondLine.text == "Na" && secondSubSecondLine.text == "H2SO4"
                                || firstSubSecondLine.text == "H2SO4" && secondSubSecondLine.text == "Na")
                                    isTrueSecondLine.text = "Задание выполнено";
                                else
                                    isTrueSecondLine.text = "Задание не выполнено";
                                break;
                            }
                        case "THIRDLINE":
                            {
                                if (firstSubThirdLine.text == "Na" && secondSubThirdLine.text == "H2SO4"
                                || firstSubThirdLine.text == "H2SO4" && secondSubThirdLine.text == "Na")
                                    isTrueThirdLine.text = "Задание выполнено";
                                else
                                    isTrueThirdLine.text = "Задание не выполнено";
                                break;
                            }
                        case "FOURTHLINE":
                            {
                                if (firstSubFourthLine.text == "Na" && secondSubFourthLine.text == "H2SO4"
                                || firstSubFourthLine.text == "H2SO4" && secondSubFourthLine.text == "Na")
                                    isTrueFourthLine.text = "Задание выполнено";
                                else
                                    isTrueFourthLine.text = "Задание не выполнено";
                                break;
                            }
                        case "FIFTHLINE":
                            {
                                if (firstSubFifthLine.text == "Na" && secondSubFifthLine.text == "H2SO4"
                                || firstSubFifthLine.text == "H2SO4" && secondSubFifthLine.text == "Na")
                                    isTrueFifthLine.text = "Задание выполнено";
                                else
                                    isTrueFifthLine.text = "Задание не выполнено";
                                break;
                            }
                    }
                    break;
                }
            case "work_4":
                {
                    switch (canInput)
                    {
                        case "FIRSTLINE":
                            {
                                if (firstSubFirstLine.text == "C" && secondSubFirstLine.text == "H2SO4"
                                || firstSubFirstLine.text == "H2SO4" && secondSubFirstLine.text == "C")
                                    isTrueFirstLine.text = "Задание выполнено";
                                else
                                    isTrueFirstLine.text = "Задание не выполнено";
                                break;
                            }
                        case "SECONDLINE":
                            {
                                if (firstSubSecondLine.text == "C" && secondSubSecondLine.text == "H2SO4"
                                || firstSubSecondLine.text == "H2SO4" && secondSubSecondLine.text == "C")
                                    isTrueSecondLine.text = "Задание выполнено";
                                else
                                    isTrueSecondLine.text = "Задание не выполнено";
                                break;
                            }
                        case "THIRDLINE":
                            {
                                if (firstSubThirdLine.text == "C" && secondSubThirdLine.text == "H2SO4"
                                || firstSubThirdLine.text == "H2SO4" && secondSubThirdLine.text == "C")
                                    isTrueThirdLine.text = "Задание выполнено";
                                else
                                    isTrueThirdLine.text = "Задание не выполнено";
                                break;
                            }
                        case "FOURTHLINE":
                            {
                                if (firstSubFourthLine.text == "C" && secondSubFourthLine.text == "H2SO4"
                                || firstSubFourthLine.text == "H2SO4" && secondSubFourthLine.text == "C")
                                    isTrueFourthLine.text = "Задание выполнено";
                                else
                                    isTrueFourthLine.text = "Задание не выполнено";
                                break;
                            }
                        case "FIFTHLINE":
                            {
                                if (firstSubFifthLine.text == "C" && secondSubFifthLine.text == "H2SO4"
                                || firstSubFifthLine.text == "H2SO4" && secondSubFifthLine.text == "C")
                                    isTrueFifthLine.text = "Задание выполнено";
                                else
                                    isTrueFifthLine.text = "Задание не выполнено";
                                break;
                            }
                    }
                    break;
                }
        }
    }
}
