using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    [SerializeField] GameObject waterColliders;
    [SerializeField] GameObject waterCollider;
    [SerializeField] float spawnTimer;
    [SerializeField] float spawnTime;

    private void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0)
        {
            spawnTimer = spawnTime;
            GameObject water = Instantiate(waterCollider, transform.position, transform.rotation, waterColliders.transform);
            //water.transform.parent = waterColliders.transform;
            //water.GetComponent<Rigidbody>().AddForce(transform.rotation.eulerAngles.normalized * 1000f);
        }
    }
}
