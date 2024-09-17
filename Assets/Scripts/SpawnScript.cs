using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
   public GameObject pipePrefabs;
   private float max_Y=2f, min_Y=-2f;
   public float delayTime=1.4f;
   public float nextSpawnTime;
   
    void Update()
    {
        if(Time.time>nextSpawnTime){
            Spawn();
            nextSpawnTime=Time.time+delayTime;
        }
    }
    void Spawn(){

        Vector3 spawnPosition = this.transform.position;
        spawnPosition.y=Random.Range(min_Y,max_Y);
        Instantiate(pipePrefabs,spawnPosition,this.transform.rotation);
    }
}
