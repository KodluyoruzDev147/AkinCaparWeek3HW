using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackManager : MonoBehaviour
{
    public static StackManager instance;

    public GameObject stackParent;
    public GameObject previousCube;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        CubeManager.instance.AddToCubesStack(previousCube);
    }

    public void Stack(GameObject stackedCube)
    {
        CubeManager.instance.StackUp(stackedCube);
        stackedCube.transform.parent = stackParent.transform;
        CubeManager.instance.AddToCubesStack(stackedCube);


        Vector3 desiredPos = new Vector3(previousCube.transform.localPosition.x, 0.5f, previousCube.transform.localPosition.z);
        stackedCube.transform.localPosition = desiredPos;
        stackedCube = previousCube;
    }

}
