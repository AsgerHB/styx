using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{
    protected readonly StateSystem _system;

    public State(StateSystem system)
    {
        _system = system;
    }

    public virtual IEnumerator Start()
    {
        yield break;
    }

    public virtual IEnumerator Accept()
    {
        yield break;
    }

    public virtual IEnumerator TurnHaven()
    {
        yield break;
    }

    public virtual IEnumerator TurnHell()
    {
        yield break;
    }
}
