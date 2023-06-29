using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScinControl : MonoBehaviour
{
    public int skinNum;
    public Button buyButton;
    public Image iLock;
    public int price;
    private int coin;

    public TextMeshProUGUI equipped;

    public Sprite falseLock;
    public Sprite trueLock;
    public GameObject coinSprite;

    public Image[] skins;

    private void Start()
    {
        coin = PlayerPrefs.GetInt("Coins");
        if (PlayerPrefs.GetInt("scin1" + "buy") == 0)
        {
            foreach (Image img in skins)
            {
                if ("scin1" == img.name)
                {
                    PlayerPrefs.SetInt("scin1" + "buy", 1);
                    PlayerPrefs.SetInt("scin1" + "equip", 1);
                }
                else
                {
                    PlayerPrefs.SetInt(GetComponent<Image>().name + "buy", 0);
                }
            }
        }
    }

    private void Update()
    {
        if (PlayerPrefs.GetInt(GetComponent<Image>().name + "buy") == 0)
        {
            iLock.GetComponent<Image>().sprite = falseLock;
            equipped.text = price.ToString();
        }
        else if (PlayerPrefs.GetInt(GetComponent<Image>().name + "buy") == 1)
        {
            iLock.GetComponent<Image>().sprite = trueLock;
            if (PlayerPrefs.GetInt(GetComponent<Image>().name + "equip") == 1)
            {
                if (PlayerPrefs.GetInt("language") == 0)
                {
                    equipped.text = "equipped";
                    coinSprite.SetActive(false);
                }
                else if(PlayerPrefs.GetInt("language") == 1)
                {
                    equipped.text = "Используется";
                    coinSprite.SetActive(false);
                }
            }
            else if (PlayerPrefs.GetInt(GetComponent<Image>().name + "equip") == 0)
            {
                if (PlayerPrefs.GetInt("language") == 0)
                {
                    equipped.text = "equip";
                    coinSprite.SetActive(false);
                }
                else if (PlayerPrefs.GetInt("language") == 1)
                {
                    equipped.text = "Использовать";
                    coinSprite.SetActive(false);
                }

            }
        }
    }
    public void buy()
    {
        if (PlayerPrefs.GetInt(GetComponent<Image>().name + "buy") == 0)
        {
            if (coin >= price)
            {

                iLock.GetComponent<Image>().sprite = trueLock;
                if (PlayerPrefs.GetInt("language") == 0)
                {
                    equipped.text = "equipped";
                }
                else if (PlayerPrefs.GetInt("language") == 1)
                {
                    equipped.text = "Используется";
                    
                }
                coinSprite.SetActive(false);
                coin -= price;

                PlayerPrefs.SetInt(GetComponent<Image>().name + "buy", 1);
                PlayerPrefs.SetInt("skinNum", skinNum);
                PlayerPrefs.SetInt("Coins", coin);

                foreach (Image img in skins)
                {
                    if (GetComponent<Image>().name == img.name)
                    {
                        PlayerPrefs.SetInt(GetComponent<Image>().name + "equip", 1);
                    }
                    else
                    {
                        PlayerPrefs.SetInt(img.name + "equip", 0);
                    }
                }
            }
        }
        else if (PlayerPrefs.GetInt(GetComponent<Image>().name + "buy") == 1)
        {
            iLock.GetComponent<Image>().sprite = trueLock;
            if (PlayerPrefs.GetInt("language") == 0)
            {
                equipped.text = "equipped";
            }
            else if (PlayerPrefs.GetInt("language") == 1)
            {
                equipped.text = "используется";
            }
            coinSprite.SetActive(false);
            PlayerPrefs.SetInt(GetComponent<Image>().name + "equip", 1);
            PlayerPrefs.SetInt("skinNum", skinNum);

            foreach (Image img in skins)
            {
                if (GetComponent<Image>().name == img.name)
                {
                    PlayerPrefs.SetInt(GetComponent<Image>().name + "equip", 1);
                }
                else
                {
                    PlayerPrefs.SetInt(img.name + "equip", 0);
                }
            }
        }
    }
}
