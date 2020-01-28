using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HUD : MonoBehaviour
{

    public Image heatguage;
    public Image warpDriveGuage;
    public TextMeshProUGUI sunDistanceText;
    public TextMeshProUGUI DistanceFromPlanetText;
    public TextMeshProUGUI planetDistanceText;
    public CharacterStats PlayerStats;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SetFill();
        DisplayDistance();
        SetWarpDriveFill();
    }

    void SetFill()
    {
        heatguage.fillAmount = PlayerStats.heatSheilds.amount *.01f;
    }
    void DisplayDistance()
    {
        sunDistanceText.text = PlayerStats.distanceFromSun.ToString("N0");
        DistanceFromPlanetText.text = string.Format("Distance From {0}", GameManager.Instance.OrbitManager.solarSystems[0].planetarySystems[PlayerStats.characterController.index].planet.nameTag);
        planetDistanceText.text = PlayerStats.distanceFromPlanet.ToString("N0");
    }
    void SetWarpDriveFill()
    {
        warpDriveGuage.fillAmount = PlayerStats.warpDrive.amount * .01f;
    }
}
