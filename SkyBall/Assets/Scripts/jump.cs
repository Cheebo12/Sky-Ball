using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{   private Rigidbody rb;
public ParticleSystem dust;
    public float JumpForce = 5;
    public bool grounded;
    public LayerMask groundlayer;
    public float groundlength;
    private SphereCollider col;
    
    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<SphereCollider>();
        rb = GetComponent<Rigidbody>();
        grounded = true;
        
    }

    // Update is called once per frame
    void Update()
    {
          for (int i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began && grounded )
            {
                rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);                
                grounded = false;
                dustplay();
            }
        }
        
    }

    void OnCollisionEnter(Collision col){
        if(col.gameObject.tag == "Floor"){
            grounded = true;
        }
        
    }
    void dustplay(){
        dust.Play();
    }
}
