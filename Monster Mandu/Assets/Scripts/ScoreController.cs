using SaveLoad;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;
    [SerializeField]
    private Text highScoreText;

    private void Start()
    {
        GameManager.scoreValue = 0;
        GameManager.highScore = SaveLoadScore.LoadHighScore();
        print(GameManager.highScore);
        highScoreText.text = $"HighScore: {GameManager.highScore.ToString()}";
    }

    private void Update()
    {
        scoreText.text = "Score: " + GameManager.scoreValue;
    }
}
