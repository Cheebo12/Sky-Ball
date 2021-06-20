using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSetTag : MonoBehaviour
{
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void  OnTriggerEnter(Collider col){
        cube.tag = "lava";
    }
}
