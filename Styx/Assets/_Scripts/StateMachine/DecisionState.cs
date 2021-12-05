using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecisionState : State
{
    bool _hasTurned = false;

    public DecisionState(StateSystem system) : base(system)
    {
    }

    public override IEnumerator Start()
    {
        Debug.Log("Entering: Decision State");
        UpdateArrows();
        yield return new WaitForSeconds(2f);
    }

    public override IEnumerator TurnHaven()
    {
        _hasTurned = true;


        _system.Boat.Turn(Input.GetAxis("Horizontal"));

        UpdateArrows();
        yield return new WaitForSeconds(0f);
    }

    public override IEnumerator TurnHell()
    {
        _hasTurned = true;

        _system.Boat.Turn(Input.GetAxis("Horizontal"));

        UpdateArrows();
        yield return new WaitForSeconds(0f);
    }

    public override IEnumerator Accept() 
    {
        if (_hasTurned)
        {
            if (_system.Boat.CurrentDirection == Boat.Direction.Hell)
            {
                Debug.Log("...Changing States! ...To Hell!");
                _system.SetState(new PassangerState(_system));
                _system.Arrows.HideArrows();
                yield return new WaitForSeconds(0f);
            }
            if (_system.Boat.CurrentDirection == Boat.Direction.Heaven)
            {
                Debug.Log("...Changing States! ...To Heaven!");
                _system.SetState(new PassangerState(_system));
                _system.Arrows.HideArrows();
                yield return new WaitForSeconds(0f);
            }
        }
    }

    void UpdateArrows()
    {
        if(!_hasTurned || _system.Boat.CurrentDirection == Boat.Direction.Undecided){
            _system.Arrows.FaceNeutral();
        }
        else if(_system.Boat.CurrentDirection == Boat.Direction.Hell){
            _system.Arrows.FaceHell();
        }
        else if(_system.Boat.CurrentDirection == Boat.Direction.Heaven){
            _system.Arrows.FaceHeaven();
        }
    }
}
