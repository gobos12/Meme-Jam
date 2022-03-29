using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    private MeshRenderer meshRenderer;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer.enabled = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Car") && CheckpointSingle.CheckPoint1 && CheckpointSecond.CheckPoint2 && CheckpointThird.CheckPoint3)
        {
            meshRenderer.enabled = false;
        }
    }
}
