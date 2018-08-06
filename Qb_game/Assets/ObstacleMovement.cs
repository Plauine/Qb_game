﻿using System.Collections;
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
	}

    void OnCollisionEnter(Collision collision){
        if(collision.collider.tag == "Destroyer"){
            ScoreManager.score += 1;
            Destroy(gameObject);
        }
    }
}
