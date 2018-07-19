using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour {

    public Rigidbody rb;

    public float forwardForce;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
    void FixedUpdate () {
        rb.AddForce(0, 0, -forwardForce * Time.deltaTime);
        if(transform.position.y < 0){
            Destroy(transform);
        }
	}
}
