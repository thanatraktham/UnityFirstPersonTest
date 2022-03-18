using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    [SerializeField] private string selectableTag = "Selectable";
    [SerializeField] private Material highlightMaterial;
    [SerializeField] private Material defaultMaterial;

    private Transform _selection;
    private Vector3 screenCenter = new Vector3(Screen.width/2f, Screen.height/2f, 0f);
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (_selection)
        {
            Debug.Log("Here");
            var selectionRenderer = _selection.GetComponent<Renderer>();
            selectionRenderer.material = defaultMaterial;
            _selection = null;
        }
        var ray = Camera.main.ScreenPointToRay(screenCenter);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            var hitGo = hit.transform.gameObject;
            if (hitGo.CompareTag(selectableTag))
            {
                var selectionRenderer = hitGo.GetComponent<Renderer>();
                if (selectionRenderer)
                {
                    selectionRenderer.material = highlightMaterial;
                }
                // EnableFreshnel(true, hitGo);
                _selection = hitGo.transform;
            }
        }
    }

    public void EnableFreshnel(bool enable, GameObject go)
        {
            if (go == null) return;

            var renderer = go.GetComponent<Renderer>();
            if (renderer != null)
            {
                foreach (var m in renderer.materials)
                {
                    if (m.HasProperty("_HilightON"))
                    {
                        m.SetFloat("_HilightON", enable ? 1f : 0f);
                        //m.SetFloat("_HilightIntensity", enable ? 2f : 0f);
                    }
                }
            }
        }
}
