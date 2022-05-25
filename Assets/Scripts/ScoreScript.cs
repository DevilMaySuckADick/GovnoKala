using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public int points = 0;
    private void OnGUI()
    {
        GUI.Label(new Rect(40, 40, 100, 20), "Score: " + points);
    }



}
