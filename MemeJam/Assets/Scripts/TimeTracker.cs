using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeTracker : MonoBehaviour
{
    public Text timeTxt;
    public float t1, minutes, seconds;
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if(!FinishLine.isFinished){
            t1 += Time.deltaTime;
            minutes = Mathf.FloorToInt(t1 / 60);
            seconds = Mathf.FloorToInt(t1 % 60);
        }

        timeTxt.text = "TIME: " + string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public float getTime(){
        return t1;
    }
}
