using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattingManager : SingletonMonoBehaviour<BattingManager>
{
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
        TargetDrawing.Instance.DrawingTarget();
        countDownTimer.TimerStart();
        hitCount.ResetResultText();
    }

    public void TimerFinished()
    {
        bool IsHitted = BatDrawing.Instance.JudgeHit();

        hitCount.ChangeResultText(IsHitted);
        TargetDrawing.Instance.DestroyTarget();
    }
}
