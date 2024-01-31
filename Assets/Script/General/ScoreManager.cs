using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private static ScoreManager _instance;
    public static ScoreManager Instance { get { return _instance; } }

    private static int score = 0;
    [SerializeField]
    private TextMeshProUGUI scoreText;

    private void Awake()
    {
        if (_instance != null)
        {
            Destroy(gameObject);
            return;
        }
        _instance = this;
    }

    private void Start()
    {
        score = 0;
        scoreText.text = ScoreManager.score + "";
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = ScoreManager.score + "";
    }

    public void ResetScore()
    {
        score = 0;
        scoreText.text = ScoreManager.score + "";
    }
}
