using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroState : State
{
    Dialogue.LineList _lines;
    int _progress = 0;

    public IntroState(StateSystem system) : base(system)
    {
    }

    public override IEnumerator Start()
    {
        Debug.Log("Entering: Intro State");
        _system.AnyKey.Show();
        _system.DialogueBox.SetActive(true);
        _system.Backdrop.SetActive(true);

        _lines = _system.Dialogue.PRE_INTRODUCTION;
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
            _system.Backdrop.SetActive(false);

            _system.SetState(new CharonState(_system));
            yield return new WaitForSeconds(0f);
        }
    }
}
