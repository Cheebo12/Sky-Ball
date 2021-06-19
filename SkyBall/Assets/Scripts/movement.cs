using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private Rigidbody rb;
    public Transform spawn;
    public float speed;
    // Start is called before the first frame update
    Vector3 Vec;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void update()
    {
        Debug.Log("working");
       if (Input.GetKey(KeyCode.UpArrow))  
        {  
            this.transform.Translate(Vector3.forward * Time.deltaTime);  
        }  
         
        if (Input.GetKey(KeyCode.DownArrow))  
        {  
            this.transform.Translate(Vector3.back * Time.deltaTime);  
        }  
         
        if (Input.GetKey(KeyCode.LeftArrow))  
        {  
            this.transform.Rotate(Vector3.up, -10);  
        }  
        
        if (Input.GetKey(KeyCode.RightArrow))  
        {  
            this.transform.Rotate(Vector3.up, 10);  
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
