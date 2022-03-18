using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest_2 : MonoBehaviour
{
    [SerializeField] private GameObject Panel1;
    [SerializeField] private GameObject Panel2;

    private bool panel1Pressed = false;
    private bool panel2Pressed = false;

    private void Update() {
        if (panel2Pressed && !panel1Pressed)
        {
            Debug.Log("Wrong Sequence");
        }
        else if (panel1Pressed && !panel2Pressed)
        {
            Debug.Log("Quest Done 50%");
        }
    }
    
    public void PanelPressed(int num, bool condition)
    {
        Debug.Log("Want to set panel : " + num + " To : " + condition);
        if (num == 1)
        {
            panel1Pressed = condition;
        } else if (num == 2) {
            panel2Pressed = condition;
        }
    }
}
