using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterCollider : MonoBehaviour
{
    [SerializeField] float lifeTime = 2f;
    [SerializeField] float force;
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
