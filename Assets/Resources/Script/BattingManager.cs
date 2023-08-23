using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattingManager : SingletonMonoBehaviour<BattingManager>
{
    [SerializeField] CountDownTimer countDownTimer;
    [SerializeField] HitCount hitCount;

    public int PittingTurns = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RoundStart()
    {
        // �R���[�`�������s  
        StartCoroutine("RoundPlaying");
    }

    IEnumerator RoundPlaying()
    {        
        for (int i = 0; i < PittingTurns; i++)
        {
            //�^�[���J�n
            TurnStart();

            //4�b��~
            yield return new WaitForSeconds(4);
        }

        yield break;

    }

    public void TurnStart()
    {
        TargetDrawing.Instance.DrawingTarget();
        countDownTimer.TimerStart();
        hitCount.ResetResultText();
    }

    public void TurnFinished()
    {
        bool IsHitted = BatDrawing.Instance.JudgeHit();

        hitCount.ChangeResultText(IsHitted);
        TargetDrawing.Instance.DestroyTarget();
    }
}
