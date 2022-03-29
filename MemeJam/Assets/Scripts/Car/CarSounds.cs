using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSounds : MonoBehaviour
{
 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            FindObjectOfType<AudioManager>().Play("accelerate");
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            FindObjectOfType<AudioManager>().Stop("accelerate");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            FindObjectOfType<AudioManager>().Play("brake");
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            FindObjectOfType<AudioManager>().Stop("brake");
        }
    }
}

