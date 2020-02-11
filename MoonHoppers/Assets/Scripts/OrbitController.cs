using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitController : MonoBehaviour
{
    Rigidbody rb;
    public bool isOrbiting;

    //

    [HideInInspector] public PlanetarySystem planetarySystem;
    public enum OrbitalType
    {
        Planet,
        Satellite,
    }

    public OrbitalType orbitalType;

    public string nameTag;
    [HideInInspector] public int satellitePlace;
    [HideInInspector] public float OrbitalCycle;
    public float rotY = 0;
    //


    private void Awake()
    {
        isOrbiting = true;


    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //rb.angularVelocity = new Vector3(0, objectRotationSpeed, 0);
        if (isOrbiting)
        {
            if (orbitalType == OrbitalType.Planet) PlanetaryOrbit(transform);
        }
    }

    private void LateUpdate()
    {
        if (isOrbiting)
        {
            if (orbitalType == OrbitalType.Satellite) SatellitesOrbit(transform);
        }
    }

    void PlanetaryOrbit(Transform planet)
    {
        Vector3 sun = planetarySystem.sun.transform.position;
        float distanceFromSun = planetarySystem.planet.planetDistanceFromSun;
        float distanceTilt = planetarySystem.planet.distanceTilt;
        float planetarySecondPerOrbit = planetarySystem.planet.planetarySecondPerOrbit;
        OrbitalCycle += 2 * Mathf.PI * Time.deltaTime;        
        float x = (float)planetarySystem.planet.orbitalDirection * Mathf.Sin(OrbitalCycle / planetarySecondPerOrbit) * distanceFromSun + sun.x;
        float y = (float)planetarySystem.planet.tiltDirection * Mathf.Sin(OrbitalCycle / planetarySecondPerOrbit)* distanceTilt + sun.y;
        float z = (float)planetarySystem.planet.orbitalDirection *Mathf.Cos(OrbitalCycle / planetarySecondPerOrbit) * distanceFromSun * 2 + sun.z;

        
        rotY = rotY > 359 ? 0 : rotY + planetarySystem.planet.rotationSpeed * Time.deltaTime;
        planet.position = new Vector3(x, y, z);
        planet.rotation = Quaternion.Euler(0, rotY, 0);
    }

    void SatellitesOrbit(Transform satellite)
    {
        Vector3 planet = planetarySystem.planet.orbitalBody.transform.position;
        float minDistance = planetarySystem.planet.radius + planetarySystem.satellites[satellitePlace].radius;
        float satelliteDistancefromPlanet = Mathf.Max(minDistance, planetarySystem.satellites[satellitePlace].satelliteDistancefromPlanet);
        float distanceTilt = planetarySystem.satellites[satellitePlace].distanceTilt;
        float satelliteSecondPerOrbit = planetarySystem.satellites[satellitePlace].satelliteSecondPerOrbit;
        OrbitalCycle += 2 * Mathf.PI * Time.deltaTime;
        float x = (float)planetarySystem.satellites[satellitePlace].orbitalDirection * Mathf.Sin(OrbitalCycle / satelliteSecondPerOrbit) * satelliteDistancefromPlanet + planet.x;//Mathf.Sin(OrbitalCycle / satelliteSecondPerOrbit) * (satelliteDistancefromPlanet + planet.x);
        float y = (float)planetarySystem.satellites[satellitePlace].tiltDirection * Mathf.Sin(OrbitalCycle / satelliteSecondPerOrbit) * distanceTilt + planet.y;
        float z = Mathf.Cos(OrbitalCycle / satelliteSecondPerOrbit) * satelliteDistancefromPlanet * 2 + planet.z;

        rotY = rotY > 359 ? 0 : rotY + planetarySystem.satellites[satellitePlace].rotationSpeed * Time.deltaTime * (float)planetarySystem.satellites[satellitePlace].satelliteRotationDirection;


        satellite.position = new Vector3(x, y, z);
        satellite.rotation = Quaternion.Euler(0, rotY, 0) ;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, 1000);
    }
}

