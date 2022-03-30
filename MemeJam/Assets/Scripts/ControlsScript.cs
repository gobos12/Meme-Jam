using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsScript : MonoBehaviour
{
    private GameObject g;
    private BackgroundMusic bgm;
    // Start is called before the first frame update
    void Start()
    {
        //GameObject.FindGameObjectWithTag("Music").GetComponent<BackgroundMusic>().PlayMusic();
        g = GameObject.FindGameObjectWithTag("Music");
        bgm = g.GetComponent<BackgroundMusic>();
        //bgm.PlayMusic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
