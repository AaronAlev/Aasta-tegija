using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Score : MonoBehaviour
{
    public CoinCollector scoreCount;
    public TextMeshProUGUI scoreText;

    void Update()
    {
        scoreText.SetText("Score:", scoreCount.score);
    }
}
