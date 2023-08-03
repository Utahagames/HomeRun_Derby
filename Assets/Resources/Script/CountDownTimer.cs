using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountDownTimer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;

    public float TimeLimit = 3.0f;

    public static float CountDownTime;

    bool IsTimerStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        CountDownTime = TimeLimit;

        timerText.text = CountDownTime.ToString("0.00");
    }

    // Update is called once per frame
    void Update()
    {
        if(IsTimerStarted)
        {
            if(CountDownTime >= 0.00f)
            {
                // カウントダウンタイムを整形して表示
                timerText.text = CountDownTime.ToString("0.00");
                // 経過時刻を引いていく
                CountDownTime -= Time.deltaTime;
            }
            else
            {
                IsTimerStarted = false;

                timerText.text = "0.00";

                BattingManager.Instance.TimerFinished();
            }
        }
    }

    public void TimerStart()
    {
        IsTimerStarted = true;

        CountDownTime = 3.0f;

        timerText.text = CountDownTime.ToString("0.00");
    }
}
