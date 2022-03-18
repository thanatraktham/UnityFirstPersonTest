using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest_PlaceOnBox : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Selectable"))
        {
            Debug.Log("Quest Done");
        }
    }
}
