using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Indicator : MonoBehaviour
{
    public Image indicatorPrefab;
    public List<Image> indicators;
    public List<Transform> trackedObject;
    public RectTransform canvas;
    public Camera camera;
    public GameObject planet;
    public bool isInitialized = false;
    
    // Start is called before the first frame update
    void Start()
    {
        //indicators = new Sprite[GameManager.Instance.OrbitManager.solarSystems[0].planetarySystems.Count];
        //trackedObject = new Transform[GameManager.Instance.OrbitManager.solarSystems[0].planetarySystems.Count];

        //foreach (PlanetarySystem planetarySystem in GameManager.Instance.OrbitManager.solarSystems[0].planetarySystems)
        //{
        //    //planetary
        //}

        
        

    }

    // Update is called once per frame
    void Update()
    {
        if (isInitialized == false) CreateIndicators();
        //Vector2 targetPosition = camera.WorldToViewportPoint(planet.transform.position);
        //Vector2 targetPosition = camera.WorldToScreenPoint(planet.transform.position);
        //float x = (targetPosition.x * canvas.sizeDelta.x) - (canvas.sizeDelta.x / 2);
        //float y = (targetPosition.y * canvas.sizeDelta.y) - (canvas.sizeDelta.y / 2);

        //Vector2 WorldObject_ScreenPosition = new Vector2(x, y);

        //indicator.rectTransform.localPosition = WorldObject_ScreenPosition;
        //indicator.rectTransform.localPosition = targetPosition;

        //transform.position = planet.transform.position;
        TrackPlanets();

    }

    void CreateIndicators()
    {
        indicators = new List<Image>();
        trackedObject = new List<Transform>();

        for (int i = 0; i < GameManager.Instance.CurrentSolarSystem.planetarySystems.Count; i++ )
        {
            
            var newIndicator = Instantiate(indicatorPrefab);
            newIndicator.name = string.Format("Indicator {0}", i + 1);
            newIndicator.rectTransform.SetParent(canvas);
            indicators.Add(newIndicator);
            trackedObject.Add(GameManager.Instance.CurrentSolarSystem.planetarySystems[i].planet.obitalBody.transform);
            newIndicator.rectTransform.localScale = new Vector3(40,40);
        }
        isInitialized = true;
    }

    void TrackPlanets()
    {
        for (int i = 0; i < trackedObject.Count; i++)
        {
            indicators[i].transform.position = trackedObject[i].position;
        }
    }

}
