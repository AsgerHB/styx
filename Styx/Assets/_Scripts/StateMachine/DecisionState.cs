using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecisionState : State
{
    public DecisionState(StateSystem system) : base(system)
    {
    }

    public override IEnumerator Start()
    {
        Debug.Log("Entering: Decision State");
        yield return new WaitForSeconds(2f);

    }

    public override IEnumerator TurnHaven()
    {
        Debug.Log("To Haven Button Pressed...");
        Debug.Log("...Changing States!");

        _system.cube.GetComponent<Renderer>().material.SetColor("_EmissionColor", new Color(1.2f, 1.3f, .4f));
        _system.SetState(new PassangerState(_system));
        yield return new WaitForSeconds(0f);
    }

    public override IEnumerator TurnHell()
    {
        Debug.Log("To Hell Button Pressed...");
        Debug.Log("...Changing States!");

        _system.cube.GetComponent<Renderer>().material.SetColor("_EmissionColor", new Color(2f, .4f, .4f));
        _system.SetState(new PassangerState(_system));
        yield return new WaitForSeconds(0f);
    }
}
