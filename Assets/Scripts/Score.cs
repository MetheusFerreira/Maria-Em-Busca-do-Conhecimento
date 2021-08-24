using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public float score;
    public float pointIncrease;
    public Text scoreText;

    void Start()
    {
        score = 0f;
        pointIncrease = 30f;
    }

    void Update()
    {
        scoreText.text = (int)score+"";
        score += pointIncrease*Time.deltaTime;
    }
}
