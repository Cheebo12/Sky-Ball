using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
      private Rigidbody rb;
    public Transform spawn;
    public float speed;
    public float JumpForce = 5;
    public bool grounded;
    bool jumping;   
    bool power_jump = false;
    public ParticleSystem dust;
  
    Vector3 vel;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
     
    if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) ){    
       vel = new Vector3(Input.GetAxis ("Horizontal"), 0, Input.GetAxis("Vertical"));
       rb.AddForce(vel*speed*Time.deltaTime);
    }
       if(grounded && Input.GetKey(KeyCode.Space)){
                Debug.Log("Should jump");
                rb.AddForce(Vector3.up*500f*Time.deltaTime, ForceMode.Impulse);                
                grounded = false;
                dustplay();
                jumping = false;
            }

    

    }

    void death(){
        rb.velocity = Vector3.zero;
        transform.position = new Vector3(spawn.position.x, spawn.position.y, spawn.position.z);        
    }
    void OnCollisionEnter(Collision col){
        if(col.gameObject.tag == "lava"){
            death();
        }
        else if(col.gameObject.tag == "Floor"){
            grounded = true;
        }
        else if(col.gameObject.tag == "jump"){
            power_jump = true;
        }
        else if(col.gameObject.tag == "lava"){
            death();
        }
    }
    public void ball_jump(){
        jumping = true;
    }
    void dustplay(){
        dust.Play();
    }
    
}
