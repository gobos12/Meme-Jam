using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillScript : MonoBehaviour
{
    private GameObject gameObj;
    // Start is called before the first frame update
    void Start()
    {
        gameObj = GameObject.FindGameObjectWithTag("Car");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other){
        if(other.CompareTag("Car")){
            if(CheckpointSingle.CheckPoint1 && CheckpointSecond.CheckPoint2 && CheckpointThird.CheckPoint3){
                other.transform.position = new Vector3(2912.734f, 1446.98f, -304.2961f);
                gameObj.transform.eulerAngles = new Vector3(0f, 68.483f, 0f);
            }
            else if(CheckpointSingle.CheckPoint1 && CheckpointSecond.CheckPoint2){
                other.transform.position = new Vector3(2945.668f, 1446.98f, -20.22631f);
                gameObj.transform.eulerAngles = new Vector3(0f, 190.706f, 0f);
            }
            else if(CheckpointSingle.CheckPoint1){
                other.transform.position = new Vector3(3416.188f, 1446.98f, 54.94896f);
                gameObj.transform.eulerAngles = new Vector3(0f, -74.862f, 0f);
            }
            else{
                other.transform.position = new Vector3(3371.32f, 1446.98f, 0.44f);
                gameObj.transform.eulerAngles = new Vector3(0f, 90f, 0f);
            }

        }
    }
}
