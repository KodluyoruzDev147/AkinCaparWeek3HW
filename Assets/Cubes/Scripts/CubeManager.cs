using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    public static CubeManager instance;
    public List<GameObject> cubesStack;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }


    public void AddToCubesStack(GameObject cube)
    {
        cubesStack.Add(cube);
        cube.GetComponent<Collider>().enabled = false;
    }


    public void StackUp()
    {
        foreach(GameObject _cube in cubesStack)
        {
            Vector3 currentCubePos = _cube.transform.localPosition;
            currentCubePos.y += 2f;
            _cube.transform.localPosition = currentCubePos;
        }
    }

    public void StackDown()
    {
        foreach(GameObject _cube in cubesStack)
        {
            Vector3 currentCubePos = _cube.transform.localPosition;
            currentCubePos.y -= 2f;
            _cube.transform.localPosition = currentCubePos;
        }
    }

    public void BuildEmptyRoad(GameObject emptyRoadCube)
    {
        int firstCubeToRoad = cubesStack.Count() - 1;
        Vector3 firstCubeToRoadPos = emptyRoadCube.transform.localPosition;
        cubesStack[firstCubeToRoad].transform.localPosition = firstCubeToRoadPos;
        cubesStack.Remove(cubesStack[firstCubeToRoad]);

    }


}
