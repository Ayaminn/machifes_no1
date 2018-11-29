﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{

    //　トータル制限時間
    private float totalTime;
    //　制限時間（分）
    [SerializeField]
    private int minute;
    //　制限時間（秒）
    [SerializeField]
    private float seconds;
    //　前回Update時の秒数
    private float oldSeconds;
    private Text timerText;
    public bool timeOver = false;

    void Start()
    {
        totalTime = minute * 60 + seconds;
        oldSeconds = 0f;
        timerText = GetComponentInChildren<Text>();
    }

    void Update()
    {
        //　制限時間が0秒以下なら何もしない
        if (totalTime <= 0f)
        {
            return;
        }
        //　一旦トータルの制限時間を計測；
        totalTime = minute * 60 + seconds;
        totalTime -= Time.deltaTime;

        //　再設定
        minute = (int)totalTime / 60;
        seconds = totalTime - minute * 60;

        //　タイマー表示用UIテキストに時間を表示する
        if ((int)seconds != (int)oldSeconds)
        {
            timerText.text = minute.ToString("00") + ":" + ((int)seconds).ToString("00");
        }
        oldSeconds = seconds;

        //　制限時間以下になったら…
        if (totalTime <= 0f)
        {
            timeOver = true;
        }
    }
}