using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rewired;

public class GameManager : Singleton<GameManager>
{
    private OrbitManager _orbitManager;
    public OrbitManager OrbitManager
    {
        get
        {
            return _orbitManager;
        }

        set
        {
            _orbitManager = value;
        }
    }

    public List<PlayerCharacterController> players = new List<PlayerCharacterController>();

    public SolarSystem CurrentSolarSystem;
    

    protected override void Awake()
    {
        base.Awake();
        //InitalizePlayerContoller();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void InitalizePlayerContoller()
    {
        
        for (int i = 0; i < players.Count; i++)
        {
            players[i].playerID = i;
            
            Debug.Log(i);
        }
    }
}
