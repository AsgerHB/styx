using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecisionState : State
{
    enum Direction {Hell, Haven, Undecided}
    Direction direction = Direction.Undecided;

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
        if (direction != Direction.Haven)
            Debug.Log("To Haven Button Pressed...");
        direction = Direction.Haven;
        yield return new WaitForSeconds(0f);
    }

    public override IEnumerator TurnHell()
    {
        if (direction != Direction.Hell)
            Debug.Log("To Hell Button Pressed...");
        direction = Direction.Hell;
        yield return new WaitForSeconds(0f);
    }

    public override IEnumerator Accept() 
    {
        if (direction == Direction.Hell)
        {
            Debug.Log("...Changing States!");
            _system.SetState(new PassangerState(_system));
            yield return new WaitForSeconds(0f);
        }
        if (direction == Direction.Haven)
        {
            Debug.Log("...Changing States!");
            _system.SetState(new PassangerState(_system));
            yield return new WaitForSeconds(0f);
        }

    }
}
