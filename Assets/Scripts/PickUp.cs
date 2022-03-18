using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform Destination;

    private bool isPickUp = true;
    private bool alreadyPickUp = false;

    private void Update()
    {
        if (!isPickUp && !alreadyPickUp)
        {
            Debug.Log("Check if clicked");
            alreadyPickUp = true;
            GetComponent<Rigidbody>().useGravity = false;
            // GetComponent<SphereCollider>().enabled = false;
            transform.position = Destination.position + new Vector3(1f, 1f, 1f);

            transform.parent = GameObject.Find("Destination").transform;

        }

        if (isPickUp && alreadyPickUp)
        {
            Debug.Log("Check if release");
            alreadyPickUp = false;
            transform.parent = null;
            GetComponent<Rigidbody>().useGravity = true;
            // GetComponent<SphereCollider>().enabled = true;
        }
    }

    private void OnMouseUp()
    {
        isPickUp = !isPickUp;
    }
}
