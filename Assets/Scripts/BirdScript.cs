using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BirdScript : MonoBehaviour
{
    private Rigidbody2D mybody;
    public float Upforce=300f;
public Text scoreText;
public int score=0;
public AudioSource Audio;
    void Start()
    {
        mybody=this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveBird();
    }
    void MoveBird(){
if(Input.GetKeyDown(KeyCode.Space)){
mybody.AddForce(Vector2.up* Upforce);
}

    }
    private void OnCollisionEnter2D(Collision2D collision){
          if(collision.gameObject.tag=="Pipe"){
            UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
        }
    }
    private void OnTriggerExit2D(Collider2D collision){
                if(collision.gameObject.tag=="PipeParent"){
            score++;
            scoreText.text=score.ToString();
            Audio.Play();
        }
      
    }
}

