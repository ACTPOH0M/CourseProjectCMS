using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class H2OController : MonoBehaviour
{
    public GameObject colbH2O;
    public Quaternion toFirst;
    public Quaternion fromFirst;
    public Transform targetForFirstColb;
    public Transform startPositionFirstColbH2O;
    public Material h2o;
    private float h2oValue;

    public Material smesh;

    private float smeshValue;
    private float speedInFilling = 0.00003f;
    private float speedOutFilling = 0.00003f;

    private void Start()
    {
        h2oValue = 0.03f;
        h2o.SetFloat("_Fill", h2oValue);

    }
    public void ChangePositionToSmeshAndAddSubstance()
    {
        smeshValue = smesh.GetFloat("_Fill");
        colbH2O.transform.position = Vector3.Lerp(colbH2O.transform.position, targetForFirstColb.position, 2f * Time.deltaTime);
        if (Vector3.Distance(colbH2O.transform.position, targetForFirstColb.position) < 0.01)
        {
            colbH2O.transform.rotation = Quaternion.Lerp(colbH2O.transform.rotation, toFirst, 1f * Time.deltaTime);
                smeshValue += speedInFilling;
                smesh.SetFloat("_Fill", smeshValue);
                h2oValue -= speedOutFilling;
                h2o.SetFloat("_Fill", h2oValue);
        }
    }
    public void ChangePositionOnH2OToStratPosition()
    {
        colbH2O.transform.rotation = Quaternion.Lerp(colbH2O.transform.rotation, fromFirst, 1f * Time.deltaTime);
        colbH2O.transform.position = Vector3.Lerp(colbH2O.transform.position, startPositionFirstColbH2O.position, 2f * Time.deltaTime);
    }
    public void resetColb()
    {
        h2oValue = 0.03f;
        h2o.SetFloat("_Fill", 0.03f);
    }
}
