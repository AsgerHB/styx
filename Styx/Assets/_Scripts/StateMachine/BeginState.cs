using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginState : State
{
    public BeginState(StateSystem system) : base(system)
    {
    }

    public override IEnumerator Start()
    {
        Debug.Log("Entering: Begin State");
        yield return new WaitForSeconds(0f);
        _system.SetState(new CharonState(_system));
    }
}
