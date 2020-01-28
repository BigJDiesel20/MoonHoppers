using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitManager : MonoBehaviour
{    
    public List<SolarSystem> solarSystems;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.Instance.OrbitManager = this;

        foreach (SolarSystem solarSystem in solarSystems)
        {
            int count = 0;

            foreach (PlanetarySystem planetarySystem in solarSystem.planetarySystems)
            {
                planetarySystem.sun = solarSystem.sun;
                planetarySystem.Initialize(count);                
            }
            
        }
        GameManager.Instance.CurrentSolarSystem = solarSystems[0];



    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
