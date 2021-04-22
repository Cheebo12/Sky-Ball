using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoyStickMov : MonoBehaviour
{
    Rigidbody rb;
    protected Joystick joystick;
    public float speed;
    public Transform spawn;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        joystick = FindObjectOfType<Joystick>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(joystick.Horizontal*speed*Time.deltaTime, rb.velocity.y , joystick.Vertical*speed*Time.deltaTime);   
        if(transform.position.y < 220){
            death();
        }
        
    }
    void death(){
        rb.velocity = Vector3.zero;
        transform.position = new Vector3(spawn.position.x, spawn.position.y, spawn.position.z);        
    }
    
}
