using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLevel : MonoBehaviour
{
    public string LoadName;
    public string UnloadName;
    // Start is called before the first frame update
    
    private void  OnTriggerEnter(Collider col){
        if(LoadName!=""){
            SceneManagements.Instance.Load(LoadName);
        }
        if(UnloadName != ""){
            StartCoroutine("UnloadScene");
        }
    }

    IEnumerator UnloadScene(){
        yield return new WaitForSeconds(0.1f);
        SceneManagements.Instance.UnLoad(UnloadName);
    }
}
