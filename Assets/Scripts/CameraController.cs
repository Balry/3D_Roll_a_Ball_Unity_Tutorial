using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public GameObject player;
    private Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position;
	}
	
	// Late Update is called once per frame after all items have been processed and updated
	void LateUpdate () {
        transform.position = player.transform.position + offset;
	}
} 