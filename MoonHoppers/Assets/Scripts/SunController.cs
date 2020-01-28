using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunController : MonoBehaviour
{
    public Vector3 size;    
    public Light light;
    public ParticleSystemRenderer particleSystemRenderer;
    public bool isSunGrowiing;
    
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
        particleSystemRenderer = GetComponent<ParticleSystemRenderer>();
        size = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (isSunGrowiing == true)
        {
            light.range += Time.deltaTime * 75;
            size.x += Time.deltaTime * 10;
            size.y += Time.deltaTime * 10;
            size.z += Time.deltaTime * 10;

            transform.localScale = size;
        }
    }
}
