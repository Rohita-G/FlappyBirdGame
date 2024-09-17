using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{public float speed=2.5f;
      void Update()
    {
        this.transform.Translate(Vector3.left*speed* Time.deltaTime);
        if(this.transform.position.x<-4){
            gameObject.SetActive(false);
        }
    }
    
}
