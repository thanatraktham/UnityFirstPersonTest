using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TheKiwiCoder;

public class WalkOnButton : ActionNode
{
    private WalkOnButton4 WalkOnButton4;
    protected override void OnStart() {
        WalkOnButton4 = GameObject.FindGameObjectWithTag("Button4").GetComponent<WalkOnButton4>();
        WalkOnButton4.setActive(true);
    }

    protected override void OnStop() {
    }

    protected override State OnUpdate() {
        Debug.Log("Status From WalkOnButton4 : " + WalkOnButton4.getStatus());
        if (WalkOnButton4.getStatus() == "Running")
        {
            return State.Running;
        }
        else if (WalkOnButton4.getStatus() == "Success")
        {
            return State.Success;
        }

        return State.Running;
    }
}
