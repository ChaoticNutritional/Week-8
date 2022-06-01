using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRaycast : MonoBehaviour
{
    bool prevHit;

    private void FixedUpdate()
    {
        // hit variable to store result
        RaycastHit hit;

        // a ray going from "screen coordinates" forward into our game world
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);


        // Conduct our Raycast
        if (Physics.Raycast(ray, out hit))
        {
            hit.collider.gameObject.GetComponent<MeshRenderer>().material.SetColor("_Color", Color.yellow);
        }
    }
}
