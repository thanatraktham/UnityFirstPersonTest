using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform theDest;

    private void OnMouseDown()
    {
        GetComponent<Rigidbody>().useGravity = false;
        // GetComponent<SphereCollider>().enabled = false;
        transform.position = theDest.position;

        transform.parent = GameObject.Find("Destination").transform;    
    }

    private void OnMouseUp()
    {
        transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        // GetComponent<SphereCollider>().enabled = true;
    }
}
