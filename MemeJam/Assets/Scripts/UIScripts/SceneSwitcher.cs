using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void GoToMainScene(){
        SceneManager.LoadScene("lvl1");
    }
    
    public void GoToControlsScene(){
        SceneManager.LoadScene("ControlsScene");
    }

    public void GoToStartScene(){
        GameObject.FindGameObjectWithTag("Music").GetComponent<BackgroundMusic>().StopMusic();
        SceneManager.LoadScene("StartScene");
    }

    public void GoToCustomizeScene(){
        SceneManager.LoadScene("CustomizeScene");
    }

    public void GoToCreditsScene(){
        SceneManager.LoadScene("CreditsScene");
    }

    public void ExitGame(){
        Application.Quit();
    }
}
