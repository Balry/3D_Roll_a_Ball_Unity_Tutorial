using UnityEngine;
using System.Collections;

public class PickUpRotator : MonoBehaviour {
	
    public float yRotatePoint;
    public float RotateAroundX, RotateAroundY, RotateAroundZ, RotateSpeedMod;
    private float initX;
    private float initZ;

    void Start()
    {
        initX = transform.position.x;
        initZ = transform.position.z;
    }
	// Update is called once per frame
	void Update () 
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
        //transform.RotateAround(new Vector3(1, 1, 0), Vector3.up, 40 * Time.deltaTime);
        //transform.RotateAround(new Vector3(0, 2.5f, 0), new Vector3(1, 0, 1), 100 * Time.deltaTime);
        transform.RotateAround(new Vector3(initX, yRotatePoint, initZ), new Vector3(RotateAroundX, RotateAroundY, RotateAroundZ), 100 * Time.deltaTime * RotateSpeedMod);
	}
}
