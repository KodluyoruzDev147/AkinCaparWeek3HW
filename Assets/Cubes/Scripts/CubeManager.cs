using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    public static CubeManager instance;
    public List<GameObject> cubesStack;// = new List<GameObject>();

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


    //hocam bu StackUp methodu ilk stacklenen küpte çalışıyor devamında çalışmıyor. StackManager'da çaşırıyorum bu methodu. -Akin.
    public void StackUp(GameObject cube)
    {
        for (int i = 0; i == cubesStack.Count - 1; i++)
        {
            Debug.Log("stackup çalıştı");
            Vector3 currentCubePos = cubesStack[i].transform.localPosition;
            currentCubePos.y += 2f;
            cubesStack[i].transform.localPosition = currentCubePos;

        }
    }



}
