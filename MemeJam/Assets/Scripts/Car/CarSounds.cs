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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            FindObjectOfType<AudioManager>().Play("brake");
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            FindObjectOfType<AudioManager>().Stop("brake");
        }
    }
}

