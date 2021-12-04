using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharonState : State
{
    Dialogue.LineList _lines;
    int _progress = 0;

    public CharonState(StateSystem system) : base(system)
    {
    }

    public override IEnumerator Start()
    {
        Debug.Log("Entering: Charon State");
        _system.AnyKey.Show();
        _system.DialogueBox.SetActive(true);

        _lines = _system.Dialogue.INTRODUCTION;
        _system.DialogueBox.GetComponent<Text>().text = _lines.Lines[_progress].Text;
        
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

            _system.cube.GetComponent<Renderer>().material.SetColor("_EmissionColor", new Color(0f, 1.4f, 1.4f));

            _system.AnyKey.Hide();

            _system.SetState(new PassangerState(_system));
            yield return new WaitForSeconds(0f);
        }
    }
}
