using System;
using UnityEngine;

public class RigidBodyScript : MonoBehaviour
{
    public Transform originalPosition;
    private Rigidbody rigidBody;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "SpherePosition")
        {
            rigidBody.linearVelocity = Vector3.zero;
            transform.position = originalPosition.position;
            transform.rotation = originalPosition.rotation;
        }
    }
}
