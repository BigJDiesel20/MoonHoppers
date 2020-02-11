using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlanetarySystem
{
    public enum Direction
    {
        Clockwize = 1,
        CounterClockwise = -1,
    }
    [System.Serializable]
    public class Planet
    {
        [Header("Planet Name")]
        public string nameTag;
        [Header("Planet Celestial Body")]
        public GameObject orbitalbodyPrefab;
        [HideInInspector]
        public GameObject orbitalBody;
        [Header("Planet Distance Settings")]
        public float planetDistanceFromSun;
        [Header("Planet Orbit Settings")]
        public float planetarySecondPerOrbit;
        public Direction orbitalDirection = Direction.Clockwize;
        [Header("Planet Orbital Tilt")]
        public float distanceTilt;
        public Direction tiltDirection = Direction.Clockwize;
        [Header("Planet Rotation Settings")]
        public float rotationSpeed;        
        public Direction planetRotationDirection = Direction.Clockwize;
        public float gravity;
        public float Gravity
        {
            get
            {
                return gravity;
            }
            set
            {

            }
        }
        public float radius;
    }
    [System.Serializable]
    public class Satellite
    {
        [Header("Satellite Name")]
        public string nameTag;
        [Header("Satellite Celestial Body")]
        public GameObject orbitalbodyPrefab;

        public GameObject orbitalBody;
        [Header("Satellite Distance Settings")]
        public float satelliteDistancefromPlanet;
        [Header("Satellite Orbit Settings")]
        public float satelliteSecondPerOrbit;
        public Direction orbitalDirection = Direction.Clockwize;
        [Header("Satellite Orbital Tilt")]
        public float distanceTilt;
        public Direction tiltDirection = Direction.Clockwize;
        [Header("Satellite Rotation Settings")]
        public float rotationSpeed;
        public Direction satelliteRotationDirection = Direction.Clockwize;

        public float radius;

    }

    
    [HideInInspector] public GameObject sun;

    [Header("Planet & Satellites")]
    public Planet planet;   
    public List<Satellite> satellites;
    


    public void Initialize(int count, GameObject SolarSystemConatiner)
    {
        
        if (planet != null)
        {
            GameObject planetorbitalbodyClone = MonoBehaviour.Instantiate(planet.orbitalbodyPrefab);
            planetorbitalbodyClone.name = planet.nameTag != "" ? planet.nameTag: "Unnamed Planet";
            planet.orbitalBody = planetorbitalbodyClone;
            planet.orbitalBody.transform.SetParent(SolarSystemConatiner.transform);
            planet.radius = planetorbitalbodyClone.GetComponent<SphereCollider>().bounds.extents.x;
            planet.orbitalBody.GetComponent<OrbitController>().planetarySystem = this;
            
        }
        if (satellites != null)
        {
            for (int i = 0; i < satellites.Count; i++)
            {
                GameObject satelliteorbitalbodyClone = MonoBehaviour.Instantiate(satellites[i].orbitalbodyPrefab);
                satelliteorbitalbodyClone.name = satellites[i].nameTag != "" ? satellites[i].nameTag : "Unnamed Satellite";
                satellites[i].orbitalBody = satelliteorbitalbodyClone;
                satellites[i].orbitalBody.transform.SetParent(SolarSystemConatiner.transform);
                satellites[i].radius = satelliteorbitalbodyClone.GetComponent<SphereCollider>().bounds.extents.x;

            }
        }
        foreach (Satellite satellite in satellites)
        {
            satellite.orbitalBody.GetComponent<OrbitController>().planetarySystem = this;
            satellite.orbitalBody.GetComponent<OrbitController>().satellitePlace = count;
            count++;
        }
    }

   
}


