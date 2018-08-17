using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesManager : MonoBehaviour {

    public GameObject obstacle;
    public float spawnTime = 3f;
    public Transform[] spawnPoints;

	// Use this for initialization
	void Start () {
        InvokeRepeating("generateObstacles", spawnTime, spawnTime);
	}

    void generateObstacles(){
        for (int i = 0; i < spawnPoints.Length; i++){
            int spawn = Random.Range(0, 2);
            if(spawn == 1){
                Instantiate(obstacle, spawnPoints[i].position, spawnPoints[i].rotation);
            }
        }
    }
}
