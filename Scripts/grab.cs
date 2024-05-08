using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grab : MonoBehaviour
{
    public bool isGrabbing = false;
    private GameObject grabbedObject = null;
    public float grabRange = 2.0f; // Example range for grabbing
    public float throwForce = 10.0f; // Example force for throwing

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (!isGrabbing)
            {
                AttemptGrab();
            }
            else
            {
                ThrowGrabbedObject();
            }
        }
    }

    void AttemptGrab()
    {
        // Check for colliders within a certain range
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, grabRange);
        foreach (Collider2D collider in colliders)
        {
            if (collider.gameObject.CompareTag("Player") || collider.gameObject.CompareTag("Player2")) // Simplified condition
            {
                isGrabbing = true;
                grabbedObject = collider.gameObject;
                grabbedObject.GetComponent<Rigidbody2D>().isKinematic = true;
                grabbedObject.transform.SetParent(transform);
                break;
            }
        }
    }

    void ThrowGrabbedObject()
    {
        if (grabbedObject != null)
        {
            grabbedObject.GetComponent<Rigidbody2D>().isKinematic = false;
            grabbedObject.transform.SetParent(null);
            // Use Vector2 for 2D physics
            Vector2 throwDirection = new Vector2(transform.localScale.x, 0).normalized; // Assumes facing direction matches scale.x
            grabbedObject.GetComponent<Rigidbody2D>().AddForce(throwDirection * throwForce, ForceMode2D.Impulse);
            isGrabbing = false;
            grabbedObject = null;
        }
    }
}
