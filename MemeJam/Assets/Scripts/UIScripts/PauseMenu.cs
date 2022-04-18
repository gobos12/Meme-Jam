using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GamePaused = false; //pause menu state
    public GameObject pauseMenuUI; //canvas that contains pause menu

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            if(!GamePaused){ //checks pause menu state
                Pause();
            }
        }
    }

    public void Resume(){
        pauseMenuUI.SetActive(false); //deactivates pause menu
        Time.timeScale = 1f; //unfreezes time
        GamePaused = false;
    }

    void Pause(){
        pauseMenuUI.SetActive(true); //activates pause menu
        Time.timeScale = 0f; //freezes time
        GamePaused = true;
    }

    public void QuitGame(){
        Application.Quit();
    }
}
