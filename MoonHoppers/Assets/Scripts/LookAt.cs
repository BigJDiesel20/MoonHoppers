using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public Transform lookat;
    public Transform player;
    public Vector3 cameraOffset;
    public float cyclesPerSeconds;
    public float cycles;
    public float a;
    
    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        ///Physics.Raycast()
        transform.up = player.up;
        cycles +=  1 * Time.deltaTime;
        if (Input.GetKey(KeyCode.Space))
        {
            cycles += .1f;
            a++;
        }
        float x = Mathf.Sin(cycles) + transform.TransformDirection(player.transform.position).x;
        float y = Mathf.Sin(cycles) + transform.TransformDirection(player.transform.position).y;
        float z = Mathf.Cos(cycles) + transform.TransformDirection(player.transform.position).z;

        transform.RotateAround(player.transform.position, transform.up, Input.GetAxis("Horizontal2") * 2);
        transform.RotateAround(player.transform.position, transform.right, Input.GetAxis("Vertical2") * 2);

        Vector3 directionToCamera = player.position - transform.position;
        
         
    }
}
