using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NatryiCorbonController : MonoBehaviour
{

    public GameObject natryi;
    public GameObject corbon;
    public Transform targetPositionAdd;
    bool startNatryi = false;
    bool startCorbon = false;
    public bool canDoNext = false;
    GameObject cloneNatryi;
    GameObject cloneCorbon;
    void Start()
    {
        startNatryi = false;
        startCorbon = false;
        canDoNext = false;
    }

    void Update()
    {
        if (startNatryi)
        {
            cloneNatryi.transform.position = Vector3.Lerp(cloneNatryi.transform.position, targetPositionAdd.position, 2f * Time.deltaTime);
            if (Vector3.Distance(cloneNatryi.transform.position, targetPositionAdd.position) < 0.01)
            {
                cloneNatryi.AddComponent<Rigidbody>();
                canDoNext=true;
                startNatryi = false;
            }
        }
        if (startCorbon)
        {
            cloneCorbon.transform.position = Vector3.Lerp(cloneCorbon.transform.position, targetPositionAdd.position, 2f * Time.deltaTime);
            if (Vector3.Distance(cloneCorbon.transform.position, targetPositionAdd.position) < 0.01)
            {
                cloneCorbon.AddComponent<Rigidbody>();
                canDoNext = true;
                startCorbon = false;
            }
        }
    }

    public void ChangePositionNatryi()
    {
        startNatryi = true;
        cloneNatryi = Instantiate(natryi, natryi.transform.position, Quaternion.identity);
        cloneNatryi.transform.localScale = new Vector3(1, 1, 1);
        cloneNatryi.AddComponent<BoxCollider>();
    }
    public void ChangePositionCorbon()
    {
        startCorbon = true;
        cloneCorbon = Instantiate(corbon, corbon.transform.position, Quaternion.identity);
        cloneCorbon.transform.localScale = new Vector3(1, 1, 1);
        cloneCorbon.AddComponent<BoxCollider>();
    }
    public void DeleteNatryi()
    {
        Destroy(cloneNatryi);
        startNatryi = false;
    }
    public void DeleteCorbon()
    {
        Destroy(cloneCorbon);
        startCorbon=false;
    }
}
