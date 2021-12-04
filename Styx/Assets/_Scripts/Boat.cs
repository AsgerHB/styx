using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Boat : MonoBehaviour
{
    public float TurnSpeed = 20;
    public float MaxTurn = 20;
    public float UncertaintyMargin = 3;
    public enum Direction {Hell, Heaven, Undecided}
    public Direction CurrentDirection = Direction.Undecided;

    float _initialRotation;

    // Start is called before the first frame update
    void Start()
    {
        _initialRotation = transform.eulerAngles.y;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.eulerAngles.y < _initialRotation - UncertaintyMargin)
            CurrentDirection = Direction.Hell;
        else if (transform.eulerAngles.y > _initialRotation + UncertaintyMargin)
            CurrentDirection = Direction.Heaven;
        else
            CurrentDirection = Direction.Undecided;
    }

    public void Turn(float axisValue)
    {
        var y = transform.eulerAngles.y;

        float turnModifier = 1f;
        
        if (axisValue < 0)
            turnModifier = Math.Min(1, (y - (_initialRotation-MaxTurn)) / MaxTurn);
        
        if (axisValue > 0)
            turnModifier = Math.Min(1, ((_initialRotation+MaxTurn) - y) / MaxTurn);

        transform.Rotate(0f, axisValue*TurnSpeed*turnModifier*Time.deltaTime, 0f);
    }
}
