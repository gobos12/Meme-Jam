using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointThird : MonoBehaviour
{
    public static bool CheckPoint3 = false;
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
            CheckPoint3 = true;
            meshRenderer.enabled = false;
        }
    }
}
