using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard2 : MonoBehaviour
{
    [SerializeField]
    Transform targetCamera;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(targetCamera);
        transform.forward = -transform.forward;
    }
}
