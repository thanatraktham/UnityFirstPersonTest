using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest_2 : MonoBehaviour
{
    [SerializeField] private GameObject Panel1;
    [SerializeField] private GameObject Panel2;
    ////////////////////Add Panel///////////////////

    [SerializeField] private Material wrongSequenceMat;
    [SerializeField] private Material rightSequenceMat;

    private bool panel1Pressed = false;
    private bool panel2Pressed = false;
    ///////////////////Add Condition/////////////////
    private bool normalSequence = true;

    private void Update() { // 
        // Debug.Log("Panel 1 : " + panel1Pressed);
        // Debug.Log("Panel 2 : " + panel2Pressed);
        if (!normalSequence)
        {
            if (panel1Pressed)
            {
                var _renderer = Panel1.GetComponent<Renderer>();
                _renderer.material = wrongSequenceMat;
                _renderer = Panel2.GetComponent<Renderer>();
                _renderer.material = wrongSequenceMat;
            }
        }
        else
        {
            if (panel2Pressed && !panel1Pressed)
            {
                Debug.Log("Wrong Sequence");
                normalSequence = false;
                var _renderer = Panel2.GetComponent<Renderer>();
                _renderer.material = wrongSequenceMat;
            }
            else if (panel1Pressed && !panel2Pressed)
            {
                Debug.Log("Quest Done 50%");
                var _renderer = Panel1.GetComponent<Renderer>();
                _renderer.material = rightSequenceMat;
                
            }
            else if (panel1Pressed && panel2Pressed)
            {
                Debug.Log("Quest Done 100%");
                var _renderer = Panel1.GetComponent<Renderer>();
                _renderer.material = rightSequenceMat;
                _renderer = Panel2.GetComponent<Renderer>();
                _renderer.material = rightSequenceMat;
            }
        }
    }
    
    public void PanelPressed(int num, bool condition)
    {
        // Debug.Log("Want to set panel : " + num + " To : " + condition);
        if (num == 1)
        {
            panel1Pressed = condition;
        } else if (num == 2) {
            panel2Pressed = condition;
        }
    }
}
