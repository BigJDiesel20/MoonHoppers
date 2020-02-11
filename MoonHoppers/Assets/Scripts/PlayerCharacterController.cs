using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerCharacterController : MonoBehaviour
{

    public Rigidbody rb;
    public float debug;
    public float pitch = .1f, roll = .2f, yaw = .1f;

    public bool inGravityWell;
    public Camera camera;
    public float velocity;

    public float speed = 50;
    public float warpSpeed = 300;
    public float maxSpeed;
    public float curentspeed;
    public ParticleSystem particleSystem;
    CharacterStats PlayerStats;
    public bool isUsingWarpDrive;
    public int index;
    public List<PlanetarySystem> planetarySystems;
    public bool pressed;
    public bool isContollingCamera;
    public GameObject cameraDirection;
    public SpringJoint grapingHook;
    public GameObject Connect;

    public int playerID;
    //public Player player;
    public float testAxis;

    public float HorizontalL = 0;
    public float HorizontalR = 0;
    public float VerticalL = 0;
    public float VerticalR = 0;
    public float BoostInput = 0;
    public bool WarpInput = false;
    public bool BreakInput = false;
    public bool LockOnInput = false;
    public bool LookInput = false;
    public bool PlusInput = false;
    public bool MinusInput = false;
    
    private void OnHorizontal(InputValue value)
    {
        HorizontalL = value.Get<float>();
    }
    private void OnHorizontal2(InputValue value)
    {
        HorizontalR = value.Get<float>();
    }
    private void OnVertical(InputValue value)
    {
        VerticalL = value.Get<float>();
    }
    private void OnVertical2(InputValue value)
    {
        VerticalR = value.Get<float>();
    }
    private void OnBoost(InputValue value)
    {
        BoostInput = value.Get<float>();
    }
    private void OnWarp(InputValue value)
    {
        WarpInput = value.isPressed;
    }
    private void OnBreak(InputValue value)
    {
        BreakInput = value.isPressed;
    }
    private void OnLockOn(InputValue value)
    {
        LockOnInput = value.isPressed;
    }
    private void OnLook(InputValue value)
    {
        LookInput = value.isPressed;
    }
    private void OnPlus(InputValue value)
    {
        PlusInput = value.isPressed;
    }
    private void OnMinus(InputValue value)
    {
        MinusInput = value.isPressed;
    }

   
    

    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
        PlayerStats = GetComponent<CharacterStats>();
        grapingHook = GetComponent<SpringJoint>();
        
    }

    // Update is called once per frame
    void Update()
    {
        testAxis = HorizontalL;
        if (planetarySystems == null)
        {
            planetarySystems = GameManager.Instance.CurrentSolarSystem.planetarySystems;
            return;
        }

        if (LookInput)
        {
            float rotX = -VerticalR * 90;
            float rotY = HorizontalR * 90;
            camera.transform.localEulerAngles = new Vector3(rotX,rotY,0);
            Vector3 rayOrigin = camera.ViewportToWorldPoint(new Vector3(.5f, .5f, 0));
             RaycastHit hit;
            if (Physics.Raycast(rayOrigin,camera.transform.forward, out hit, Mathf.Infinity))
            {
                Connect = hit.collider.gameObject;
            }
            
        }
        else
        {
            camera.transform.rotation = Quaternion.Lerp(camera.transform.rotation, cameraDirection.transform.rotation, 0.05f);
            float torqueX = Mathf.Abs(VerticalL) > .2f ? VerticalL * pitch : -transform.InverseTransformDirection(rb.angularVelocity).x * .05f;
            float torqueY = Mathf.Abs(HorizontalR) > .2f ? HorizontalR * roll : transform.InverseTransformDirection(rb.angularVelocity).y * .05f;
            float torqueZ = Mathf.Abs(HorizontalL) > .2f ? HorizontalL * yaw : transform.InverseTransformDirection(rb.angularVelocity).z * .05f;


            if (transform.InverseTransformDirection(rb.velocity).y > speed * .25f) particleSystem.Play(); else particleSystem.Stop();
            var em = particleSystem.emission;
            em.rateOverTime = transform.InverseTransformDirection(rb.velocity).y;

            rb.AddRelativeTorque(new Vector3(torqueX, -torqueY, -torqueZ));

            float speedX = -transform.InverseTransformDirection(rb.velocity).x;
            float speedY = transform.InverseTransformDirection(rb.velocity).y < (maxSpeed = isUsingWarpDrive ? warpSpeed : speed) ? BoostInput * (maxSpeed = isUsingWarpDrive ? warpSpeed : speed) : (maxSpeed = isUsingWarpDrive ? warpSpeed : speed) - transform.InverseTransformDirection(rb.velocity).y;
            float speedZ = -transform.InverseTransformDirection(rb.velocity).z;

            if (PlusInput && pressed == false)
            {
                index += 1;
                
                index = index > GameManager.Instance.OrbitManager.solarSystems[0].planetarySystems.Count ? 0 : index;
                pressed = true;
            }
            else if (MinusInput && pressed == false)
            {
                index -= 1;
                index = index < 0 ? GameManager.Instance.OrbitManager.solarSystems[0].planetarySystems.Count : index;
                pressed = true;
            }
            else if (PlusInput == false && MinusInput == false)
            {
                pressed = false;
            }
            else
            {
            }
            

            if (LockOnInput)
            {
                

                Vector3 direction = transform.position - GameManager.Instance.CurrentSolarSystem.planetarySystems[index].planet.orbitalBody.transform.position;
                direction = direction.normalized;
                Quaternion rotateTo = Quaternion.FromToRotation(-Vector3.up, direction);

                transform.rotation = Quaternion.Slerp(transform.rotation, rotateTo, .05f);
                Debug.Log("LockOn");
            }
            if (WarpInput && PlayerStats.warpDrive.limitReached == false)
            {
                isUsingWarpDrive = true;
                PlayerStats.ActivateWarpDrive();
            }
            else
            {
                isUsingWarpDrive = false;
            }
            if (BreakInput)
            {
                rb.AddRelativeForce(-transform.InverseTransformDirection(rb.velocity) * .5f);
                rb.AddRelativeTorque(-transform.InverseTransformDirection(rb.angularVelocity) * .5f);

            }
            else
            {
                rb.AddRelativeForce(speedX, speedY, speedZ);
            }


            if (BoostInput < .2f)
            {

                rb.AddRelativeForce(0, -(transform.InverseTransformDirection(rb.velocity).y * .75f), 0);
            }

            camera.fieldOfView = transform.InverseTransformDirection(rb.velocity).y > .02f ? 60 + (40 * transform.InverseTransformDirection(rb.velocity).y / speed) : 60;
            curentspeed = transform.InverseTransformDirection(rb.velocity).y;
        }
        
    }

    void GravityWell(GameObject player)
    {      
        
        Quaternion otherRotation = Quaternion.FromToRotation(transform.up, Vector3.up) * transform.rotation;
        transform.rotation = Quaternion.Slerp(transform.rotation, otherRotation, 50 * Time.deltaTime);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireCube(transform.position, new Vector3(500, 500, 500));
    }

    


}
