using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PassangerState : State
{
    string[] _texts;
    int _progress = 0;

    public PassangerState(StateSystem system) : base(system)
    {
    }

    public override IEnumerator Start()
    {
        Debug.Log("Entering: Passanger State");
        _system.AnyKey.Show();
        _system.DialogueBox.SetActive(true);

        if (_system.Boat.CurrentDirection == Boat.Direction.Hell)
            _texts = DialogueText.HELL[_system.Progress];
        else
            _texts = DialogueText.HEAVEN[_system.Progress];

        _system.DialogueBox.GetComponent<Text>().text = _texts[_progress];

        yield return new WaitForSeconds(0f);
    }

    public override IEnumerator Accept()
    {
        Debug.Log("Accept Button Pressed...");

        if (_progress +1 < _texts.Length)
        {
            _progress += 1;
            _system.DialogueBox.GetComponent<Text>().text = _texts[_progress];
        }
        else
        {
            Debug.Log("...Changing States!");

            _system.cube.GetComponent<Renderer>().material.SetColor("_EmissionColor", new Color(1.4f, 0, 1.4f));
            _system.SetState(new DecisionState(_system));
            _system.AnyKey.Hide();
            _system.DialogueBox.SetActive(false);
            _system.Progress += 1;
            yield return new WaitForSeconds(0f);
        }
    }
}
