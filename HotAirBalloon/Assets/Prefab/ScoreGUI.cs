using System;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI))]
public class ScoreGUI : MonoBehaviour
{
    [SerializeField] private Player1 target;

    private TextMeshProUGUI _text;
    
    private void Start()
    {
        _text = GetComponent<TextMeshProUGUI>();
        
        target.ScoreEvent += DisplayScore;
    }

    private void DisplayScore(int score)
    {
        _text.text = score.ToString();
    }
}
