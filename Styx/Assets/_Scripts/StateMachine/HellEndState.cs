using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HellEndState : State
{
    Dialogue.LineList _lines;
    int _progress = 0;

    public HellEndState(StateSystem system) : base(system)
    {
    }

    public override IEnumerator Start()
    {
        Debug.Log("Entering: Hell End State");
        _system.AnyKey.Show();
        _system.DialogueBox.SetActive(true);
        _system.Backdrop.SetActive(true);

        _system.AnyKey.Hide();
        _system.EndText.SetActive(true);

        _lines = _system.Dialogue.HELL_ENDING;
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
            Debug.Log("...Game end!");


            yield return new WaitForSeconds(0f);
        }
    }
}
