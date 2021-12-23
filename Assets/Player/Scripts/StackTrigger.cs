using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Cube")
        {
            Debug.Log("TRIGGERED SORUN YOK");
            StackManager.instance.Stack(other.gameObject);
        }
    }
}
