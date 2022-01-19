using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foam : MonoBehaviour
{
    [SerializeField] GameObject waterColliders;
    [SerializeField] GameObject waterColliderPrefab;
    float spawnTimer;
    [SerializeField] float spawnTime;

    private void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0)
        {
            spawnTimer = spawnTime;
            GameObject waterCollider = Instantiate(waterColliderPrefab, transform.position, transform.rotation, waterColliders.transform);
            waterCollider.transform.parent = waterColliders.transform;
        }
    }
}
