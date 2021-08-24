using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public Text score;
    public Text finalText;

    void Update()
    {
        finalText.text = $"Score = {score.text}";
        score.enabled = false;
    }
}
