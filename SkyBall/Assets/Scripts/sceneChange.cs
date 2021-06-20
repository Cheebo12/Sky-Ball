using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class sceneChange : MonoBehaviour
{
 public void play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

 public void Exit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }  

 public void credit(){
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +7);
 }    
}
