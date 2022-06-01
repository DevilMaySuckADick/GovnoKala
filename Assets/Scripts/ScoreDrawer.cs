using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDrawer : MonoBehaviour
{
    public Text scoreText;
    public ScoreScript Score;
    public string prefix = "";

    void Update() {
        scoreText.text = prefix + Score.points.ToString();
    }
}
