using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    
    
    public static bool isFinished;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer.enabled = true;
        isFinished = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Car") && CheckpointSingle.CheckPoint1 && CheckpointSecond.CheckPoint2 && CheckpointThird.CheckPoint3)
        {
            FindObjectOfType<AudioManager>().Play("checkpoint");
            meshRenderer.enabled = false;
            isFinished = true;
            SceneManager.LoadScene("EndScene");
        }
    }
}
