using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PassangerState : State
{
    Dialogue.LineList _lines;
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
            _lines = _system.Dialogue.HELL[_system.Progress];
        else
            _lines = _system.Dialogue.HEAVEN[_system.Progress];

        _system.DialogueBox.GetComponent<Text>().text = _lines.Lines[_progress].Text;
        
        _system.AudioSource.clip = _lines.Lines[_progress].Clip;
        _system.AudioSource.Play();
        
        _system.AudioSource.clip = _lines.Lines[_progress].Clip;
        _system.AudioSource.Play();

        yield return new WaitForSeconds(0f);
    }

    public override IEnumerator Accept()
    {
        Debug.Log("Accept Button Pressed...");

        if (_progress +1 < _lines.Lines.Count)
        {
            _progress += 1;
            _system.DialogueBox.GetComponent<Text>().text = _lines.Lines[_progress].Text;
        
            _system.AudioSource.clip = _lines.Lines[_progress].Clip;
            _system.AudioSource.Play();
        }
        else
        {
            Debug.Log("...Changing States!");
            
            if (_system.Progress + 1 < _system.Dialogue.HEAVEN.Count )
            {
                _system.SetState(new DecisionState(_system));
                _system.AnyKey.Hide();
                _system.DialogueBox.SetActive(false);
                _system.Progress += 1;
            }
            else
            {
                Debug.Log("...Game Ended!");
                _system.AnyKey.Hide();
                _system.DialogueBox.SetActive(false);
                if (_system.Boat.CurrentDirection == Boat.Direction.Hell)
                    _system.SetState(new HellEndState(_system));
                else
                    _system.SetState(new HeavenEndState(_system));
            }

            yield return new WaitForSeconds(0f);
        }
    }
}
