using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StateSystem : MonoBehaviour
{
    public int Progress = 0;
    public GameObject DialogueBox;
    public Dialogue Dialogue;
    public AudioSource AudioSource;
    public GameObject Backdrop;
    public GameObject Face;
    public GameObject EndText;
    public GameObject EndButton;
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
        if(DialogueBox == null)
            Debug.LogError("DialogueBox missing! Please specify!");
        if(Dialogue == null)
            Debug.LogError("Dialogue missing! Please specify!");
        if(AudioSource == null)
            Debug.LogError("AudioSource missing! Please specify!");
        if(Backdrop == null)
            Debug.LogError("Backdrop missing! Please specify!");
        if(EndText == null)
            Debug.LogError("EndText missing! Please specify!");
        if(Face == null)
            Debug.LogError("Face missing! Please specify!");
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

    public void OnGameEnd()
    {
        EndButton.SetActive(true);
        EndButton.GetComponent<Button>().onClick.AddListener(delegate { EndGame(); });
    }

    private void EndGame()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
