using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public bool isGrounded { get; private set; } = false;

    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("Collision enter");
        isGrounded = true;
    }

    private void OnTriggerExit(Collider collider)
    {
        Debug.Log("Collision exit");
        isGrounded = false;
    }
}
