using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManagements : MonoBehaviour
{
    public static SceneManagements Instance{set;get;}
    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
        Load("player");
        Load("Level 1");
        Load("Level 2");
    }

    // Update is called once per frame
    public void Load(string sceneName)
    {
        if(!SceneManager.GetSceneByName(sceneName).isLoaded){
            SceneManager.LoadScene(sceneName,LoadSceneMode.Additive);
        }
    }
    public void UnLoad(string sceneName)
    {
        if(SceneManager.GetSceneByName(sceneName).isLoaded){
            SceneManager.UnloadScene(sceneName);
        }
    }
}
