using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{
    private TimeTracker timer;
    private GameObject t;
    public float endTime, minutes, seconds;
    public Text timeTxt;
    // Start is called before the first frame update
    async void Start()
    {
        t = GameObject.FindGameObjectWithTag("timeTracker");
        timer = t.GetComponent<TimeTracker>();
        
        endTime = timer.getTime();
        minutes = Mathf.FloorToInt(endTime / 60);
        seconds = Mathf.FloorToInt(endTime % 60);

        timeTxt.text = "TOTAL TIME: " + string.Format("{0:00}:{1:00}", minutes, seconds);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
