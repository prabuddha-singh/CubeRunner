#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;
public class PauseScript : MonoBehaviour
{
    public static bool paused =false;
    public GameObject pauseUI;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(paused){
                resume();           
             }
             else{
                pause();
             }
        }
    }
    public void resume(){
        pauseUI.SetActive(false);
        Time.timeScale=1f;
        paused=false;
    }
     void pause(){
       pauseUI.SetActive(true);
       Time.timeScale=0f;
       paused=true;
    }

    public void LoadMenu(){
        SceneManager.LoadScene("Menu");
        Time.timeScale=1f;
        Debug.Log("menu");
    }
    public void QuitGame(){
        Application.Quit();
       Debug.Log("Quitting");
    }
}
#endif