using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TheKiwiCoder;

public class WalkOnPedal : ActionNode
{
    private WalkOnPedal3 WalkOnPedal3;
    protected override void OnStart() {
        WalkOnPedal3 = GameObject.FindGameObjectWithTag("Pedal3").GetComponent<WalkOnPedal3>();
        WalkOnPedal3.setActive(true);
    }

    protected override void OnStop() {
    }

    protected override State OnUpdate() {
        Debug.Log("Status From WalkOnPedal3 : " + WalkOnPedal3.getStatus());
        if (WalkOnPedal3.getStatus() == "Running")
        {
            return State.Running;
        }
        else if (WalkOnPedal3.getStatus() == "Success")
        {
            return State.Success;
        }

        return State.Running;
    }
}
