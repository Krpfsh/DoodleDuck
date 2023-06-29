using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using YG;

[RequireComponent(typeof(Rigidbody2D))]
public class Duck : MonoBehaviour
{
    public float movementSpeed = 10f;
    public float movementSpeedArrows = 4f;
    float movement = 0f;
    Rigidbody2D rb;
    private float levelWidth = 3;

    private bool gameStart = false;
    public TextMeshProUGUI startTMPro;



    public GameObject coinPrefab;
    private float ySpawnPlatform = 8f;

    public GameObject enemyPrefab;
    public GameObject enemyPurplePrefab;
    public GameObject gameOver;
    public GameObject arrowsMobilePlay;
    public GameObject arrowsMobilePlayy;
    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        Time.timeScale = 0f;
    }
    private void Start()
    {
        StartCoroutine(SpawnCoins());
        StartCoroutine(SpawnEnemy());
        StartCoroutine(SpawnPurpleEnemy());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey && gameStart == false)
        {
            gameStart = true;
            Time.timeScale = 1f;
            startTMPro.gameObject.SetActive(false);
            rb.AddForce(new Vector2(0, 15), ForceMode2D.Impulse);
        }
        //перемещение утки справо налево запределами экрана
        DontExitTheScreen();
        if (YandexGame.EnvironmentData.deviceType == "desktop")
        {
            arrowsMobilePlay.SetActive(false);
            arrowsMobilePlayy.SetActive(false);
            movement = Input.GetAxis("Horizontal") * movementSpeed;
        }
        else if (YandexGame.EnvironmentData.deviceType == "mobile" || YandexGame.EnvironmentData.deviceType == "tablet")
        {
            arrowsMobilePlay.SetActive(true);
            arrowsMobilePlayy.SetActive(true);
        }
        //Отвечает за поворот спрайта
        if (movement < 0)
        {
            transform.localScale = Vector3.one;
        }
        else if (movement > 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

    }
    private void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;
    }
    private void DontExitTheScreen()
    {
        if (transform.position.x > levelWidth)
        {
            transform.position -= new Vector3(2 * levelWidth, 0, 0);
        }
        else if (transform.position.x < -levelWidth)
        {
            transform.position += new Vector3(2 * levelWidth, 0, 0);
        }
    }
    private IEnumerator SpawnCoins()
    {
        while (true)
        {
            yield return new WaitForSeconds(2.4f);
            Instantiate(coinPrefab, new Vector2(Random.Range(-2.3f, 2.3f), this.transform.position.y + (ySpawnPlatform + Random.Range(0.2f, 2f))), Quaternion.identity);
        }
    }
    private IEnumerator SpawnEnemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(15f);
            Instantiate(enemyPrefab, new Vector2(Random.Range(-2.3f, 2.3f), this.transform.position.y + (ySpawnPlatform + Random.Range(0.2f, 2f))), Quaternion.identity);
        }
    } private IEnumerator SpawnPurpleEnemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(40f);
            Instantiate(enemyPurplePrefab, new Vector2(Random.Range(-2.3f, 2.3f), this.transform.position.y + (ySpawnPlatform + Random.Range(0.2f, 2f))), Quaternion.identity);
        }
    }

    public void LeftOnButton()
    {
        movement = -movementSpeedArrows;
    }
    public void RightOnButton()
    {
        movement = movementSpeedArrows;
    }
    public void Stop()
    {
        movement = 0;
    }
}
