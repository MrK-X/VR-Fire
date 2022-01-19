using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoamCollider : MonoBehaviour
{
    [SerializeField] float lifeTime = 2f;
    [SerializeField] float force;
    [SerializeField] public float fireReductionRate;

    void Start()
    {
        var direction = transform.TransformDirection(Vector3.forward);
        GetComponent<Rigidbody>().AddForce(direction * force, ForceMode.Impulse);
    }

    void Update()
    {
        lifeTime -= Time.deltaTime;
        if (lifeTime <= 0)
        {
            Destroy(gameObject);
        }
    }
}
