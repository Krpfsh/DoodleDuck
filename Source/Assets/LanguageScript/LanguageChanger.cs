using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanguageChanger : MonoBehaviour
{
    public int language;
    private void Start()
    {
        language = PlayerPrefs.GetInt("language", language);
    }
    public void ENGLanguage()
    {
        language = 0;
        PlayerPrefs.SetInt("language", language);
    }
    public void RULanguage()
    {
        language = 1;
        PlayerPrefs.SetInt("language", language);
    }
    
}
