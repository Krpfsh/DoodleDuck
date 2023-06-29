using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainMenuCoins : MonoBehaviour
{
    public TextMeshProUGUI coin;
    public TextMeshProUGUI bestScore;
    private int coins;
    private int bestScoreNumber;
    private void Start()
    {
        coins = PlayerPrefs.GetInt("Coins");
        bestScoreNumber = PlayerPrefs.GetInt("BestScore");
    }
    // Update is called once per frame
    void Update()
    {
        coin.text = coins.ToString();
        bestScore.text = bestScoreNumber.ToString();
    }
}
