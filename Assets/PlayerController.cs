using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 lastMousePosition;
    private Vector3 difference;
    [SerializeField] float sensivity;
    private float xPos;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            lastMousePosition = Input.mousePosition;
        }

        if(Input.GetMouseButton(0))
        {
            difference = lastMousePosition - Input.mousePosition;
            lastMousePosition = Input.mousePosition;

            xPos = Mathf.Clamp((transform.position.x - (difference.x * sensivity)), -4.5f, 4.5f);
            transform.position = new Vector3(xPos, transform.position.y, transform.position.z);    
        }
    }
}
