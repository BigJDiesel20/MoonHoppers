using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{

    public Stats heatSheilds;
    public Stats warpDrive;    
    public SphereCollider sun;
    public Transform planet;
    public float distanceFromSun;
    public float distanceFromPlanet;
    public PlayerCharacterController characterController;
    


    // Start is called before the first frame update

        
    void Start()
    {
        heatSheilds = new Stats(0, 0, 100);
        warpDrive = new Stats(100, 0, 100, false);
        characterController = GetComponent<PlayerCharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (sun == null || planet == null)
        {
            sun = GameManager.Instance.OrbitManager.solarSystems[0].sun.GetComponentInChildren<SphereCollider>();
            planet = GameManager.Instance.OrbitManager.solarSystems[0].planetarySystems[characterController.index].planet.obitalBody.transform;
            return;
        }
        SunDamage();
        PlanetDistance();
    }

    void SunDamage()
    {
        float MaxDistance = 4000;
        distanceFromSun = Vector3.Distance(transform.position, sun.transform.position) - sun.bounds.extents.x;
        if (distanceFromSun > MaxDistance)
        {
            float rate = 2;            
            heatSheilds.Decrease(rate);

        }
        else
        {
            float rate = 3 * (1 - distanceFromSun / MaxDistance);
            heatSheilds.Increase(rate);

        }
    }

    void PlanetDistance()
    {
        distanceFromPlanet = Vector3.Distance(transform.position, planet.position);
    }

    public void ActivateWarpDrive()
    {
        
        if (warpDrive.limitReached == false)
        {
            warpDrive.DecreaseToLimit(10f);            
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Sun"))
        {

            transform.gameObject.SetActive(false);
            
        }
    }
}
