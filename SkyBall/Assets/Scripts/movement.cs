using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private Rigidbody rb;
    private bool isFlat = true;
    public float JumpForce = 5;
    public Transform spawn;
    float speed = 1000.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = Vector3.zero;


        dir.x = Input.acceleration.x;
        dir.y= Input.acceleration.y;

        // clamp acceleration vector to unit sphere
        if (dir.sqrMagnitude > 1)
            dir.Normalize();

        // Make it move 10 meters per second instead of 10 meters per frame...
        
        dir = Quaternion.Euler(90,0,0)*dir;
        dir *= Time.deltaTime;

        // Move object
        rb.AddForce(dir * speed);

        if(transform.position.y < 220){
            death();
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
    }
}
