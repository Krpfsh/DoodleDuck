using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public AudioClip audioSource;
    
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.StartsWith("Duck"))
        {
            AudioSource.PlayClipAtPoint(audioSource, transform.position);
            
            CoinText.coin++;
            PlayerPrefs.SetInt("Coins", CoinText.coin);
            Destroy(gameObject);
        }
    }

}
