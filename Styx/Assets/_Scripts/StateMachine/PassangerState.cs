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
        _system.AnyKey.Show();
        yield return new WaitForSeconds(2f);
    }

    public override IEnumerator Accept()
    {
        Debug.Log("Accept Button Pressed...");
        Debug.Log("...Changing States!");
        _system.SetState(new DecisionState(_system));
        _system.AnyKey.Hide();
        yield return new WaitForSeconds(0f);
    }
}
