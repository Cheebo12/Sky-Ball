using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnChange : MonoBehaviour
{
    public Transform spawnch;
    public Transform player;
    // Start is called before the first frame update
    
    private void  OnTriggerEnter(Collider col){
        spawnch.transform.position = new Vector3(player.position.x, player.position.y, player.position.z);
    }

   
}
