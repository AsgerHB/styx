using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharonState : State
{
    public CharonState(StateSystem system) : base(system)
    {
    }

    public override IEnumerator Start()
    {
        Debug.Log("Entering: Charon State");
        yield return new WaitForSeconds(0f);
    }

    public override IEnumerator Accept()
    {
        Debug.Log("Accept Button Pressed...");
        Debug.Log("...Changing States!");
        _system.SetState(new PassangerState(_system));
        yield return new WaitForSeconds(0f);
    }
}
