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
        UpdateArrows();
        yield return new WaitForSeconds(2f);
    }

    public override IEnumerator TurnHaven()
    {
        Debug.Log("To Haven Button Pressed...");
        Debug.Log("...Changing States!");

        _system.cube.GetComponent<Renderer>().material.SetColor("_EmissionColor", new Color(1.2f, 1.3f, .4f));


        _system.Boat.Turn(Input.GetAxis("Horizontal"));


        yield return new WaitForSeconds(0f);
        UpdateArrows();
    }

    public override IEnumerator TurnHell()
    {
        Debug.Log("To Hell Button Pressed...");
        Debug.Log("...Changing States!");

        _system.cube.GetComponent<Renderer>().material.SetColor("_EmissionColor", new Color(2f, .4f, .4f));

        _system.Boat.Turn(Input.GetAxis("Horizontal"));


        yield return new WaitForSeconds(0f);
        UpdateArrows();
    }

    public override IEnumerator Accept() 
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

    void UpdateArrows()
    {
        if(_system.Boat.CurrentDirection == Boat.Direction.Undecided){
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
