using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{   private Rigidbody rb;
public ParticleSystem dust;
    public float JumpForce = 5;
    public bool grounded;
    bool jumping;   
   
    
    // Start is called before the first frame update
    void Start()
    {
        jumping = false;
        rb = GetComponent<Rigidbody>();
        grounded = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(jumping && grounded){
        Debug.Log("Should jump");
        rb.velocity += Vector3.up*5f;                
        grounded = false;
        dustplay();
        jumping = false;
        }
        
    }

    void OnCollisionEnter(Collision col){
        if(col.gameObject.tag == "Floor"){
            grounded = true;

        }
        
    }
    public void ball_jump(){
        jumping = true;
    }
    void dustplay(){
        dust.Play();
    }
}
