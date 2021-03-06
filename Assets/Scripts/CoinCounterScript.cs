﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounterScript : MonoBehaviour
{
    Text coinText;
    public static int coinAmount;

    void Start()
    {
        coinText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = coinAmount.ToString();
    }

    public int getCoinAmount()
    {
        return coinAmount;
    }

    public void setCoinAmount(int n)
    {
        coinAmount = n;
    }
}