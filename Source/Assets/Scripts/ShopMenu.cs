using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShopMenu : MonoBehaviour
{
    public TextMeshProUGUI coin;
    private int coins;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        coins = PlayerPrefs.GetInt("Coins");
        coin.text = coins.ToString();
       
    }
}
