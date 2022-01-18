using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField]
    ParticleSystem particles;
    [SerializeField]
    float fireReductionRate;
    [SerializeField]
    float emissionRate;
    public float hSliderValue;

    private void Start()
    {
        emissionRate = particles.emission.rateOverTime.Evaluate(1);
        print(emissionRate);
    }

    //private void Update()
    //{
    //    print(emissionRate);
    //    //var emission = particles.emission;
    //    //emission.rateOverTime = hSliderValue;
    //}

    //private void OnParticleCollision(GameObject other)
    //{
    //    //rate -= fireReductionRate;
    //    print(emissionRate);
    //    var emission = particles.emission;
    //    //emission.emissionRateOverTime -= fireReductionRate;
    //    //emission.rateOverTime = emissionRate;
    //}

    //private void OnParticleTrigger()
    //{
    //    print("particle trigger");
    //}

    void OnGUI()
    {
        hSliderValue = GUI.HorizontalSlider(new Rect(25, 45, 100, 30), hSliderValue, 5.0f, 200.0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        print("enter");
        emissionRate -= fireReductionRate;
        var emission = particles.emission;
        emission.rateOverTime = emissionRate;
    }
}
