using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
  public static bool Ispause = false;
  public GameObject pauseMenuUI;
    // Update is called once per frame
    void Start()
    {
        pauseMenuUI.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(Ispause){
                Resume();
            }else{
                Pause();
            }
        }
        
    }

    public void Resume(){
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;   
        Ispause = false;     
    }

    void Pause(){
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        Ispause = true;
    }

    public void LoadMenu(){
        SceneManager.LoadScene("Main Menu");
    }

    public void Quit(){
        Application.Quit();
    }
}
