using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H2SO4Controller : MonoBehaviour
{
    public GameObject colbH2SO4;
    public Quaternion toSecond;
    public Quaternion fromSecond;
    public Transform targetForSecondColb;
    public Transform startPositionSecondColbH2SO4;
    public Material h2so4;
    private float h2so4Value;

    public Material smesh;

    private float smeshValue;
    private float speedInFilling = 0.00003f;
    private float speedOutFilling = 0.00003f;

    private void Start()
    {
        h2so4Value = 0.03f;
        h2so4.SetFloat("_Fill", h2so4Value);
    }

    public void ChangePositionToSmeshAndAddSubstance()
    {
        smeshValue = smesh.GetFloat("_Fill");
        colbH2SO4.transform.position = Vector3.Lerp(colbH2SO4.transform.position, targetForSecondColb.position, 2f * Time.deltaTime);
        if (Vector3.Distance(colbH2SO4.transform.position, targetForSecondColb.position) < 0.01)
        {
            colbH2SO4.transform.rotation = Quaternion.Lerp(colbH2SO4.transform.rotation, toSecond, 1f * Time.deltaTime);
                smeshValue += speedInFilling;
                smesh.SetFloat("_Fill", smeshValue);
                h2so4Value -= speedOutFilling;
                h2so4.SetFloat("_Fill", h2so4Value);
        }
    }
    public void ChangePositionOnH2SO4ToStratPosition()
    {
        colbH2SO4.transform.rotation = Quaternion.Lerp(colbH2SO4.transform.rotation, fromSecond, 1f * Time.deltaTime);
        colbH2SO4.transform.position = Vector3.Lerp(colbH2SO4.transform.position, startPositionSecondColbH2SO4.position, 2f * Time.deltaTime);
    }
    public void resetColb()
    {
        h2so4Value = 0.03f;
        h2so4.SetFloat("_Fill", 0.03f);
    }
}
