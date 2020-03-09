using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] Text scoreText;
    [SerializeField] private int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        UpdateText();
    }

    public void IncrementScore()
    {
        score++;
        //score +=1;
        //score = score +1;
        UpdateText();
    }

    public void DecrementScore()
    {
        score--;
        //score -= 1;
        //score = score -1;
        UpdateText();
    }

    // Update is called once per frame
    private void UpdateText()
    {
        scoreText.text = $"Sanity/Comfort: {score}";
    }
}
