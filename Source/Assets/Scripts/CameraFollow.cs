using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI scoreNumber;
    [SerializeField] public TextMeshProUGUI bestScoreNumber;
    public Transform target;
    public int number;
    public int bestScore;
    // Update is called once per frame
    private void Start()
    {
        bestScore = PlayerPrefs.GetInt("BestScore");
    }
    private void Update()
    {
        number = ((int)(transform.position.y * 10));
        scoreNumber.text = number.ToString();
        if(bestScore <= number)
        {
            bestScore= number;
            PlayerPrefs.SetInt("BestScore", bestScore);
        }
        bestScoreNumber.text = bestScore.ToString();

    }
    void LateUpdate()
    {
        if (target.position.y > transform.position.y)
        {
            Vector3 newPos = new Vector3(transform.position.x, target.position.y, transform.position.z);
            transform.position = newPos;
        }
    }
}
