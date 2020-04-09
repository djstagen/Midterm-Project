using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManagerSanity : MonoBehaviour
{
    [SerializeField] Text scoreText;
    [SerializeField] private int score2;
    // Start is called before the first frame update
    void Start()
    {
        score2 = 10;
        UpdateText();
    }

    public void IncrementScore()
    {
        score2++;
        //score +=1;
        //score = score +1;
        UpdateText();
    }

    public void DecrementScore()
    {
        score2--;
        //score -= 1;
        //score = score -1;
        UpdateText();
    }

    // Update is called once per frame
    private void UpdateText()
    {
        scoreText.text = $"Sanity: {score2}";
    }
}
