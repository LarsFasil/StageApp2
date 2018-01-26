using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectActiveScript : MonoBehaviour {

    private MeshRenderer thisMesh;
    GameObject myCube;
    public bool actieveQR;

	void Start () {
        myCube = transform.GetChild(0).gameObject;
        actieveQR = false;
        //thisMesh = this.GetComponent<MeshRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        DeactivateMyCube();
	}

    public void ActivateMyCube()
    {
        myCube.SetActive(true);
    }
    void DeactivateMyCube()
    {
        if (!actieveQR && myCube.activeSelf)
        {
            myCube.SetActive(false);
        }
    }
}
