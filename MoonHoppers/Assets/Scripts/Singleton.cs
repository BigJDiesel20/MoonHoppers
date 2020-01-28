using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{

    private static T _instance;
    public static  T Instance
    {
        get
        {
            return _instance;
        }
    }
    // Start is called before the first frame update

    protected virtual void Awake()
    {
        _instance = (T)this;
    }

    void Start()
    {

        if (_instance != null)
        {
            Debug.LogWarning(string.Format("Tried to instaiate second instance of {0}", typeof(T).Name));
            Destroy(gameObject);
        }
        else
        {            
            _instance = (T)this;
        }
        
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
