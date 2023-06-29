using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinText : MonoBehaviour
{
    public TextMeshProUGUI coins;
    public static int coin;
    private void Start()
    {
        coin = PlayerPrefs.GetInt("Coins");
    }
    // Update is called once per frame
    void Update()
    {
        coins.text = coin.ToString();
    }
}
