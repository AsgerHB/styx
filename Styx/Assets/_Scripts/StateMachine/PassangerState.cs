using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassangerState : State
{
    public PassangerState(StateSystem system) : base(system)
    {
    }

    public override IEnumerator Start()
    {
        Debug.Log("Entering: Passanger State");
        yield return new WaitForSeconds(2f);
    }

    public override IEnumerator Accept()
    {
        Debug.Log("Accept Button Pressed...");
        Debug.Log("...Changing States!");

        _system.cube.GetComponent<Renderer>().material.SetColor("_EmissionColor", new Color(1.4f, 0, 1.4f));
        _system.SetState(new DecisionState(_system));
        yield return new WaitForSeconds(0f);
    }
}
