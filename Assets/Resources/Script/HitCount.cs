using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HitCount : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI resultText;
    [SerializeField] TextMeshProUGUI scoreText;

    public int HitScore { get; set; } = 0;

    // Start is called before the first frame update
    void Start()
    {
        ResetResultText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetResultText()
    {
        resultText.text = "";
    }

    public void ChangeResultText(bool IsHitted)
    {
        if(IsHitted)
        {
            resultText.text = "HIT";

            HitScore++;
            ChangeScoreText();
        }
        else
        {
            resultText.text = "STRIKE";
        }
    }

    public void ResetScoreText()
    {
        scoreText.text = "0";
        HitScore = 0;
    }

    public void ChangeScoreText()
    {
        scoreText.text = HitScore.ToString();
    }
}
