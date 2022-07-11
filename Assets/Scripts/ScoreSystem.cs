using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private float scoreRate = 1;

    private float score;

    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime * scoreRate;
        scoreText.text = Mathf.FloorToInt(score).ToString();
    }
}
