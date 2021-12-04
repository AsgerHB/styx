using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadText : MonoBehaviour
{
    struct Dialog
    {
        public string Charon1;
        public string Passanger1;
    }
    // Start is called before the first frame update
    void Start()
    {
        TextAsset dialogData = Resources.Load<TextAsset>("Dialog");

        Dialog dialog = JsonUtility.FromJson<Dialog>(dialogData.text);

        Debug.Log(dialog.Charon1);
        Debug.Log(dialog.Passanger1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
