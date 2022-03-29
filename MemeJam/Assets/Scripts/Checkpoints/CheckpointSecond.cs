using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointSecond : MonoBehaviour
{
    public static bool CheckPoint2 = false;
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
        if (other.CompareTag("Car"))
        {
            CheckPoint2 = true;
            meshRenderer.enabled = false;
        }
    }
}
