using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRaycast : MonoBehaviour
{   
    // A boolean value that tells us whether or not we have hit something yet, prevents us from NullRef exceptioning at the start of our code
    bool hitYet;

    // A gameobject to hold our last gameobject hit by a raycast
    private GameObject lastObject;

    private void FixedUpdate()
    {
        RaycastHit hit;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (hitYet)
        {
            if (Physics.Raycast(ray, out hit))
            {
                hitYet = true;
                if (hitObjectGetter(ray, hit) != null)
                {
                    lastObject = hit.collider.gameObject;

                    Debug.Log("Now touching " + lastObject);

                   lastObject.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.yellow);
                }
            }
            else
            {
                Debug.Log("No longer touching " + lastObject);
                lastObject.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.red);
            }
        }
        else
        {
            if (Physics.Raycast(ray, out hit))
            {
                hitYet = true;
                lastObject = hit.collider.gameObject;
                hit.collider.gameObject.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.yellow);
            }
        }
    }

    private GameObject hitObjectGetter(Ray aRay, RaycastHit aHit)
    {
        if(Physics.Raycast(aRay, out aHit))
        {
            return aHit.collider.gameObject;
        }
        else
        {
            return null;
        }
    }
}
