using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachToPlatform : MonoBehaviour
{
    

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player"){
            Debug.Log("On Platform");
            other.transform.parent = transform;
        }
    }
    private void OnTriggerExit(Collider other) {
        if(other.tag == "Player"){
            other.transform.parent = null;
        }
    }
}
