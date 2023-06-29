using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YG;
using UnityEngine.UI;

public class RewardADSCoins : MonoBehaviour
{
    public YandexGame sdk;
    public void AdButton()
    {
        sdk._RewardedShow(1);
    }
    public void AdButtonMoney()
    {
        CoinText.coin += 25;
        PlayerPrefs.SetInt("Coins", CoinText.coin);
    }
}
