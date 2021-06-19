using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBall : MonoBehaviour
{
    private Rigidbody rb;
    public ParticleSystem dust;
    public float JumpForce = 5;
    public bool grounded;
    bool jumping;   
    bool power_jump = false;
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
       
            if(grounded && Input.GetKey(KeyCode.Space)){
                Debug.Log("Should jump");
                rb.AddForce(Vector3.up*500f*Time.deltaTime, ForceMode.Impulse);                
                grounded = false;
                dustplay();
                jumping = false;
            }
            else if(power_jump && grounded){
                Debug.Log("Should jump");
                rb.velocity += Vector3.up*10f;                
                grounded = false;
                dustplay();
                power_jump = false;
            }
           
    }
     
    void OnCollisionEnter(Collision col){
        if(col.gameObject.tag == "Floor"){
            grounded = true;
        }
        else if(col.gameObject.tag == "jump"){
            power_jump = true;
        }
    }
    
    public void ball_jump(){
        jumping = true;
    }
    void dustplay(){
        dust.Play();
    }
}
