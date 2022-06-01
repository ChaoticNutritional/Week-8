using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPlace : MonoBehaviour
{
    // The object we're placing on the surface
    public Transform objectToPlace;

    private void FixedUpdate()
    {
        // hit variable
        RaycastHit hit;

        // ray from the gameObject to world
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        // Conduct raycast
        if (Physics.Raycast(ray, out hit))
        {
            // manipulate the object to place
            objectToPlace.position = hit.point; //a vector3 that shows exactly where in the world the ray hit

            // make sure the object is right side up
            objectToPlace.rotation = Quaternion.FromToRotation(Vector3.up, hit.normal);
        }


    }
}
