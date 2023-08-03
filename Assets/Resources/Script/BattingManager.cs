using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattingManager : SingletonMonoBehaviour<BattingManager>
{
    [SerializeField] BatDrawing batDrawing;
    [SerializeField] CountDownTimer countDownTimer;
    [SerializeField] HitCount hitCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TurnStart()
    {
        countDownTimer.TimerStart();
        hitCount.ResetResultText();
    }

    public void TimerFinished()
    {
        bool IsHitted = batDrawing.JudgeHit();

        hitCount.ChangeResultText(IsHitted);
    }
}
