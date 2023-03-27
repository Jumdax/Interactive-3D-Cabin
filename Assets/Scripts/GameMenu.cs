using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMenu : MonoBehaviour
{
    public void loadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // This function is called every fixed framerate frame, if the MonoBehaviour is enabled
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Quit Game");
            Application.Quit();
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }


    // LateUpdate is called every frame, if the Behaviour is enabled
    //private void Update()
    //{
    //    if(Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Space))
    //    {
    //        Debug.Log("Quit Game");
    //        Application.Quit();
    //        UnityEditor.EditorApplication.isPlaying = false; 
    //    }
    //}
}
