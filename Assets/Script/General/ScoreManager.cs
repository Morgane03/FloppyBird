using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private static ScoreManager _instance;
    public static ScoreManager Instance { get { return _instance; } }

    private static int _score;
    [SerializeField]
    private TextMeshProUGUI _scoreText;

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
        _score = 0;
        _scoreText.text = ScoreManager._score + "";
    }

    public void IncreaseScore()
    {
        _score++;
        _scoreText.text = ScoreManager._score + "";
    }

    public void ResetScore()
    {
        _score = 0;
        _scoreText.text = ScoreManager._score + "";
    }
}
