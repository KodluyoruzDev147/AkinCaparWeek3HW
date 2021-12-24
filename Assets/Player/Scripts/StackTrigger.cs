using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Cube")
        {
            StackManager.instance.Stack(other.gameObject);
        }

        if(other.tag == "Empty Road")
        {
            StackManager.instance.FillEmptyRoad(other.gameObject);
        }
    }
}
