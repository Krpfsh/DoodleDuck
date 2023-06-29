using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroy : MonoBehaviour
{
    public GameObject player;
    public GameObject greenPlatformPrefab;
    public GameObject bluePlatformPrefab;
    public GameObject yellowPlatformPrefab;
    public GameObject brownPlatformPrefab;
    public GameObject coinPrefab;

    private float ySpawnPlatform = 8f;
    private float leftScreenBorder = -2.3f;
    private float rightScreenBorder = 2.3f;
    private void SpawnIndentity(Collider2D collision, string nameObj, GameObject prefab, int upBorderRandom)
    {
        if (collision.gameObject.name.StartsWith(nameObj))
        {
            if (Random.Range(1, upBorderRandom) == 1)
            {
                Destroy(collision.gameObject);
                Instantiate(prefab, new Vector2(Random.Range(leftScreenBorder, rightScreenBorder), player.transform.position.y + (ySpawnPlatform + Random.Range(0.2f, 0.8f))), Quaternion.identity);
            }
            else
            {
                collision.gameObject.transform.position = new Vector2(Random.Range(leftScreenBorder, rightScreenBorder), player.transform.position.y + (ySpawnPlatform + Random.Range(0.2f, .8f)));
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SpawnIndentity(collision, "Blue", bluePlatformPrefab, 7);
        SpawnIndentity(collision, "Green", greenPlatformPrefab, 7);
        SpawnIndentity(collision, "Yellow", yellowPlatformPrefab, 10);
        SpawnIndentity(collision, "Brown", brownPlatformPrefab, 6);

        SpawnIndentity(collision, "Coin", coinPrefab, 5);
        if (collision.gameObject.name.StartsWith("Enemy") || collision.gameObject.name.StartsWith("Purple"))
        {
            Destroy(collision.gameObject);
        }
    }
}


