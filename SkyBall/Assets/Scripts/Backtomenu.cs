using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Backtomenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(LoadLevelAfterDelay());
     
        

    }

   IEnumerator LoadLevelAfterDelay()
     {
         Debug.Log("Wait");
         yield return new WaitForSeconds(10);
        Debug.Log("Done");
        SceneManager.LoadScene("Main Menu");
     }
}
