using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillerDuck : MonoBehaviour
{
    public GameObject gameOver;
    private void Update()
    {
        if (GameObject.Find("Duck") == null)
        {
            gameOver.SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.StartsWith("Duck"))
        {
            Destroy(collision.gameObject);
            gameOver.SetActive(true);
        }
    }
}
