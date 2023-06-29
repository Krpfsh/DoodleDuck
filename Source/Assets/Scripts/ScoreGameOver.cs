using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreGameOver : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI scoreNumber;
    [SerializeField] public TextMeshProUGUI scoreNumber2;
    [SerializeField] public TextMeshProUGUI coinNumber;
    [SerializeField] public TextMeshProUGUI coinNumber2;
    public AudioSource asource;
    private void Start()
    {
        asource= GetComponent<AudioSource>();
        asource.Play();
    }
    void Update()
    {
        scoreNumber2.text = scoreNumber.text;
        coinNumber2.text = coinNumber.text;
    }
}
