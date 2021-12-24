using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class StackManager : MonoBehaviour
{
    public static StackManager instance;

    public GameObject stackParent;
    public GameObject previousCube;
    public GameObject emptyRoadCubes;

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
        CubeManager.instance.StackUp();
        stackedCube.transform.parent = stackParent.transform;
        CubeManager.instance.AddToCubesStack(stackedCube);


        Vector3 desiredPos = new Vector3(previousCube.transform.localPosition.x, 0.5f, previousCube.transform.localPosition.z);
        stackedCube.transform.localPosition = desiredPos;
        stackedCube = previousCube;
    }

    public void FillEmptyRoad(GameObject emptyRoadCube)
    {
        emptyRoadCube.GetComponent<Collider>().enabled = false;
        int firstCubeToRoad = CubeManager.instance.cubesStack.Count() - 1;
        CubeManager.instance.StackDown();
        CubeManager.instance.cubesStack[firstCubeToRoad].transform.parent = emptyRoadCubes.transform;
        CubeManager.instance.BuildEmptyRoad(emptyRoadCube);
    }

}
