using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    public UnityEvent Left;
    public UnityEvent Right;
    public UnityEvent Accept;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Horizontal") < 0)
            Left.Invoke();

        if(Input.GetAxis("Horizontal") > 0)
            Right.Invoke();

        if(Input.GetButtonDown("Fire1") 
        || Input.GetButtonDown("Fire2") 
        || Input.GetButtonDown("Fire3") 
        || Input.GetButtonDown("Jump"))
            Accept.Invoke();
    }
}
