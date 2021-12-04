using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateSystem : MonoBehaviour
{
    private State _currentState;

    public void SetState(State state)
    {
        _currentState = state;
        StartCoroutine(_currentState.Start());
    }

    private void Start()
    {
        SetState(new BeginState(this));
    }

    public void OnAcceptButton()
    {
        StartCoroutine(_currentState.Accept());
    }
    public void OnHavenButton()
    {
        StartCoroutine(_currentState.TurnHaven());
    }
    public void OnHellButton()
    {
        StartCoroutine(_currentState.TurnHell());
    }
}
