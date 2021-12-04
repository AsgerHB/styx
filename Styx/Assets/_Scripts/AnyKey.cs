using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnyKey : MonoBehaviour
{
    public GameObject Prompt;

    // Start is called before the first frame update
    void Start()
    {
        if(Prompt == null)
            print("Prompt is missing! Please specify!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Show()
    {
        Prompt.SetActive(true);
    }

    public void Hide()
    {
        Prompt.SetActive(false);
    }
}
