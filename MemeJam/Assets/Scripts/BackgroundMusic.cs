using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    private AudioSource audio;
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        audio = GetComponent<AudioSource>();
    }

    public void PlayMusic(){
        if(audio.isPlaying) return;
        audio.Play();
    }
    public void StopMusic(){
        audio.Stop();
    }
}

