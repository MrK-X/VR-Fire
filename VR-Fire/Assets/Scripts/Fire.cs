using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField]
    ParticleSystem particles;
    [SerializeField]
    float emissionRate;

    private void Start()
    {
        // Default emission rate.
        if (emissionRate == 0)
        {
            emissionRate = particles.emission.rateOverTime.Evaluate(1);
        }
        else
        {
            var emission = particles.emission;
            emission.rateOverTime = emissionRate;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Water"))
        {
            emissionRate -= other.gameObject.GetComponent<FoamCollider>().fireReductionRate;
            var emission = particles.emission;
            emission.rateOverTime = emissionRate;
            if (emissionRate <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
