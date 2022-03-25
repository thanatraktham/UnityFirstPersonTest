using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TheKiwiCoder;

public class WalkOnPedal3 : MonoBehaviour
{
    [SerializeField] private Material wrongMaterial;
    [SerializeField] private Material rightMaterial;
    
    public bool active = false;
    public string status = "Running";

    private Material defaultMaterial;
    private Renderer _renderer;

    private void Start() {
        _renderer = GetComponent<Renderer>();
        defaultMaterial = _renderer.material;
    }

    private void OnTriggerEnter(Collider other) {
        if (active)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                _renderer.material = rightMaterial;
                setStatus("Success");
            }
        }
        else
        {
            StartCoroutine(RenderWrongSequenceMaterial());
        }
    }

    private IEnumerator RenderWrongSequenceMaterial()
    {
        Debug.Log(gameObject.name + " : Failure");
        _renderer.material = wrongMaterial;
        yield return new WaitForSeconds(1f);
        _renderer.material = defaultMaterial;
    }

    public string getStatus()
    {
        return status;
    }

    public void setStatus(string newStatus)
    {
        status = newStatus;
    }

    public bool isActive()
    {
        return active;
    }

    public void setActive(bool newBool)
    {
        active = newBool;
    }
}
