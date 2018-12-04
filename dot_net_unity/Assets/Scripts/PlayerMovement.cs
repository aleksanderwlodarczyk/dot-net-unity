using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private Rigidbody playerRb;
    public float speed;
    private float horizontal; 

	void Start () {
        playerRb = GetComponent<Rigidbody>();
	}
	
	
	void Update () {
        horizontal = Input.GetAxis("Horizontal");
        playerRb.AddForce(Vector3.right * speed * horizontal);
	}
}
