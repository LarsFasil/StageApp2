using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectActiveScript : MonoBehaviour {

    private MeshRenderer thisMesh;
    public bool actieveQR;

	void Start () {
        actieveQR = false;
        //thisMesh = this.GetComponent<MeshRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.LogFormat("actief!");
	}
    void checkMesh()
    {
        //if (!thisMesh.enabled && SingleCubeScript.cubeActive)
        //{
        //    SingleCubeScript.cubeActive = false;
        //}
        //if (thisMesh.enabled && !SingleCubeScript.cubeActive)
        //{
        //    SingleCubeScript.cubeActive = true;
        //}
        
    }
}
