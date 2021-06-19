using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
      private Rigidbody rb;
    public Transform spawn;
    public float speed;
    public float JumpForce = 10.0f;
    float gravity = 14.0f;
    public bool grounded;
    bool jumping;   
    bool power_jump = false;
    float verticalvel;
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
     
    if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow) ){    
       vel = new Vector3(Input.GetAxis ("Horizontal"), 0, Input.GetAxis("Vertical"));
       rb.AddForce(vel*speed*Time.deltaTime);
    }
       if(grounded){
                Debug.Log("Should jump");
                verticalvel = -gravity*Time.deltaTime;                
            if(Input.GetKey(KeyCode.Space) && !power_jump){    
                verticalvel = JumpForce;
                grounded = false;
                dustplay();
                jumping = false;
            }
        }else{
            verticalvel -= gravity*Time.deltaTime;
        }
        Vector3 moveVector = new Vector3(0f, verticalvel, 0f);
        rb.MovePosition(moveVector*Time.deltaTime);
       
        // else if(grounded && Input.GetKey(KeyCode.Space) && power_jump){
        //         rb.AddForce(Vector3.up*JumpForce*2*Time.deltaTime, ForceMode.Impulse);                
        //         grounded = false;
        //         dustplay();
        //         jumping = false;
        // }

    

    }

    void death(){
        rb.velocity = Vector3.zero;
        transform.position = new Vector3(spawn.position.x, spawn.position.y, spawn.position.z);        
    }
    void OnCollisionEnter(Collision col){
        if(col.gameObject.tag == "lava"){
            death();
        }
        else if(col.gameObject.tag == "Floor" || col.gameObject.tag == "jump" || col.gameObject.tag == "slow"||col.gameObject.tag == "flash"){
            grounded = true;
            power_jump = false;
            rb.velocity = Vector3.zero;
        }
        if(col.gameObject.tag == "jump"){
            power_jump = true;
            Debug.Log("Power_Jump true");
            rb.velocity = Vector3.zero;
        }
        
    }
    public void ball_jump(){
        jumping = true;
    }
    void dustplay(){
        dust.Play();
    }
    
}
