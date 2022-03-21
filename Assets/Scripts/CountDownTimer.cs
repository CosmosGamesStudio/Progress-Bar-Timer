using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
    public float countdownTo = 60.0F;
    [SerializeField] private EnumTimeType TimerType;

    public GameObject timeBar;
    public static double realTime; 

    void Start()
    {
        timeBar.GetComponent<Slider>().maxValue = countdownTo;
    }

    void Update()
    {
        countdownTo -= Time.deltaTime;

        // realTime = (int)countdownTo;

        realTime = System.Math.Round(countdownTo, 1);

        if(TimerType.ToString() == "StepByStep")
            timeBar.GetComponent<Slider>().value = (int) realTime;
        else if(TimerType.ToString() == "Fluent")
            timeBar.GetComponent<Slider>().value = (float) realTime;


    }


    public enum EnumTimeType
    {
        StepByStep, Fluent
    }
}
