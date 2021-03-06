using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLevel : MonoBehaviour
{
    public string LoadName;
    public string UnloadName;
    public GameObject door;
    // Start is called before the first frame update
    
    private void  OnTriggerEnter(Collider col){
        if(LoadName!=""){
            SceneManagements.Instance.Load(LoadName);
            FindObjectOfType<AudioManager>().Play("LevelChange"); 
        }
        if(UnloadName != ""){
            StartCoroutine("UnloadScene");
        }
        
        Destroy(door,2);
    }

    IEnumerator UnloadScene(){
        yield return new WaitForSeconds(0.1f);
        SceneManagements.Instance.UnLoad(UnloadName);
    }
}
