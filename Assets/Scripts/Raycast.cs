using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    //it's a fixed update function because it has to do with the physics engine.
    private void FixedUpdate()
    {
        // Create a ray variable to raycast *with*
        Ray ray = new Ray(transform.position, transform.forward);

        // Create a variable to store the HIT result of our raycast
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit))
        {
            Debug.DrawRay(transform.position, ray.direction * hit.distance, Color.yellow);
        }
        else
        {
            Debug.DrawRay(transform.position, ray.direction * 1000, Color.white);
        }
    }
}
