using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleCubeScript : MonoBehaviour
{
    public static bool cubeActive, piramidActive, ballActive;
    private MeshRenderer[] boxMeshes, piramidMeshes, ballMeshes;
    public GameObject boxParent, box;
    ObjectActiveScript[] instances;

    void Start()
    {
        cubeActive = false;
        piramidActive = false;
        ballActive = false;

        instances = boxParent.GetComponentsInChildren<ObjectActiveScript>();
        

    }

    void Update()
    {
        //CheckMeshes();
        FindQRBools();
        DrawCube();
    }

    void DrawCube()
    {
        if (cubeActive)
        {
            //showcube
            //box.SetActive(true);
        }
        else
        {
            //box.SetActive(false);
        }
    }

    void FindQRBools()
    {
        cubeActive = false;
        foreach (var i in instances)
        {
            if (i.actieveQR)
            {
                if (!cubeActive)
                {
                    //methode aanroepen in i die zijn cube zichtbaar maakt.
                    i.ActivateMyCube();
                }
                cubeActive = true;
            }
        }
    }

    void findMeshes()
    {
        GameObject[] allBoxes;
        allBoxes = GameObject.FindGameObjectsWithTag("Box");
        Debug.Log(allBoxes);
        for (int i = 0; i < allBoxes.Length; i++)
        {
            boxMeshes.SetValue(allBoxes[i].GetComponent<MeshRenderer>(), i);
        }
    }
}