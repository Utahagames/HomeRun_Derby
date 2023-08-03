using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HitCount : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI resultText;

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
        }
        else
        {
            resultText.text = "STRIKE";
        }
    }
}
