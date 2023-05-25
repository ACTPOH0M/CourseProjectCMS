using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleGeneration : MonoBehaviour
{
    public GameObject bubble;
    public GameObject position;

    IEnumerator CreateBubble()
    {
        int count = 80;
        while (count > 0)
        {
            count--;
            Instantiate(bubble, position.transform.position + Random.insideUnitSphere*0.022f, Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
        }
    }
}
