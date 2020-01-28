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
        public GameObject obitalBody;
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
        
    }
    [System.Serializable]
    public class Satellite
    {
        [Header("Satellite Name")]
        public string nameTag;
        [Header("Satellite Celestial Body")]
        public GameObject obitalBody;
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

    }

    
    [HideInInspector] public GameObject sun;

    [Header("Planet & Satellites")]
    public Planet planet;   
    public List<Satellite> satellites;



    public void Initialize(int count)
    {
        if (planet != null) planet.obitalBody.GetComponent<OrbitController>().planetarySystem = this;
        foreach (Satellite satellite in satellites)
        {
            satellite.obitalBody.GetComponent<OrbitController>().planetarySystem = this;
            satellite.obitalBody.GetComponent<OrbitController>().satellitePlace = count;
            count++;
        }
    }
    
}


