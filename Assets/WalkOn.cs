using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkOn : MonoBehaviour
{
    public Quest_2 Quest_2;

    [SerializeField] private Material defaultMaterial;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player"))
        {
            // Debug.Log("Player Triggered");
            if (other.gameObject.name == "panel1")
            {
                Quest_2.PanelPressed(1, true);
            }
            else if (other.gameObject.name == "panel2")
            {
                Quest_2.PanelPressed(2, true);
            }
            var _renderer = GetComponent<Renderer>();
            _renderer.material = defaultMaterial;
        }
    }
}
