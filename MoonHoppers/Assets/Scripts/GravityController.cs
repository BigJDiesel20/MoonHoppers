using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour
{
    public Vector3 direction;
    public float Gravity = 1;
    public bool isGrounded;
    public bool inGravityField;
    public float gravityWellRadius;
    
    
    // Start is called before the first frame update
    void Start()
    {
        isGrounded = false;
        gravityWellRadius = transform.gameObject.GetComponent<SphereCollider>().radius;
    }

    // Update is called once per frame
    void Update()
    {
        if (inGravityField)
        {

        }
    }
    private void OnTriggerStay(Collider other)
    {

        if (other.transform.CompareTag("Player"))
        {
            other.gameObject.transform.parent = transform;
            Vector3 distance = transform.position - other.transform.position;
            if (isGrounded == false) other.gameObject.GetComponent<Rigidbody>().AddForce(distance.normalized * Gravity);
            PlanetLanding(other.transform);
            other.GetComponent<CharacterStats>().warpDrive.SetLimitReached(true);
        }
        if (other.transform.CompareTag("Player") && isGrounded)
        {

            other.GetComponent<CharacterStats>().warpDrive.IncreaseToLimit(4);           

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            other.transform.SetParent(transform);
            other.GetComponent<CharacterStats>().warpDrive.SetLimitReached(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            other.transform.parent = null;
            other.GetComponent<CharacterStats>().warpDrive.SetLimitReached(false);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }

    public void PlanetLanding(Transform other)
    {
        Vector3 direction = transform.position - other.transform.position;
        direction = direction.normalized;
        Quaternion rotateTo = Quaternion.FromToRotation(Vector3.forward, direction);
        
        other.transform.rotation = Quaternion.Slerp(other.rotation, rotateTo, .01f);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, gravityWellRadius);

    }
    


}
