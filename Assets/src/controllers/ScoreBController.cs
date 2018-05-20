﻿using System;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class ScoreBController : MonoBehaviour
{
	int score = 0;
	public Text scoreUI;

    void Start()
    {
        Store.StoreState.Subscribe(state =>
        {
            int nextScore = B.GetB(state);
            if (nextScore == score)
            {
                return;
            }
            score = nextScore;
            scoreUI.text = "Cylinder: " + score.ToString();
        });
    }
}