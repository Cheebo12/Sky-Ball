using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winning : MonoBehaviour
{
    public GameObject winning;
    // Start is called before the first frame update
  void Start()
    {
        winning.SetActive(false);
        
    }

  private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player"){
            winning.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
