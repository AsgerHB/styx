using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateSystem : MonoBehaviour
{
    public GameObject cube;
    private State _currentState;

    public Boat Boat;
    public Arrows Arrows;
    public AnyKey AnyKey;

    public void SetState(State state)
    {
        _currentState = state;
        StartCoroutine(_currentState.Start());
    }

    private void Start()
    {
        SetState(new BeginState(this));

        if(Boat == null)
            Debug.LogError("Boat missing! Please specify!");
        if(Arrows == null)
            Debug.LogError("Arrows missing! Please specify!");
        if(AnyKey == null)
            Debug.LogError("AnyKey missing! Please specify!");
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
