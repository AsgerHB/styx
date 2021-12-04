using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrows : MonoBehaviour
{
    public GameObject HellHighlighted;
    public GameObject HellGreyedOut;
    public GameObject HellNeutral;
    public GameObject HeavenHighlighted;
    public GameObject HeavenGreyedOut;
    public GameObject HeavenNeutral;

    // Start is called before the first frame update
    void Start()
    {
        if (HellHighlighted == null ||
            HellGreyedOut == null ||
            HellNeutral == null ||
            HeavenHighlighted == null ||
            HeavenHighlighted == null ||
            HeavenGreyedOut == null ||
            HeavenNeutral == null)
            Debug.LogError("One or more game objects missing! Please specify!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FaceHell()
    {
        HellHighlighted.SetActive(true);
        HellGreyedOut.SetActive(false);
        HellNeutral.SetActive(false);
        HeavenHighlighted.SetActive(false);
        HeavenGreyedOut.SetActive(true);
        HeavenNeutral.SetActive(false);
    }

    public void FaceHeaven()
    {
        HellHighlighted.SetActive(false);
        HellGreyedOut.SetActive(true);
        HellNeutral.SetActive(false);
        HeavenHighlighted.SetActive(true);
        HeavenGreyedOut.SetActive(false);
        HeavenNeutral.SetActive(false);
    }

    public void FaceNeutral()
    {
        HellHighlighted.SetActive(false);
        HellGreyedOut.SetActive(false);
        HellNeutral.SetActive(true);
        HeavenHighlighted.SetActive(false);
        HeavenGreyedOut.SetActive(false);
        HeavenNeutral.SetActive(true);
    }

    public void HideArrows()
    {
        HellHighlighted.SetActive(false);
        HellGreyedOut.SetActive(false);
        HellNeutral.SetActive(false);
        HeavenHighlighted.SetActive(false);
        HeavenGreyedOut.SetActive(false);
        HeavenNeutral.SetActive(false);
    }
}
