using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    [System.Serializable]
    public class LineList 
    {
        public List<Line> Lines;
    }

    [System.Serializable]
    public class Line {
        public AudioClip Clip;
        [Multiline]
        public string Text;
    }

    public LineList INTRODUCTION;
    public List<LineList> HEAVEN;
    public List<LineList> HELL;

}
