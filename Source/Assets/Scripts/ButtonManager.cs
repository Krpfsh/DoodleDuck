using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void GoToGame()
    {
        SceneManager.LoadScene("Endless");
    }
    public void GoToShop()
    {
        SceneManager.LoadScene("Shop");
    }
    public void GoToOptions()
    {
        SceneManager.LoadScene("Options");
    }
}
