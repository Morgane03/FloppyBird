using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField]
    private GameObject _gameOverText;
    private bool _isGameOver = false;
    [SerializeField]
    private Button _restartButton;

    private void OnCollisionEnter(Collision collision)
    {
        if (!_isGameOver)
        {
            _isGameOver = true;
            GameOver();
        }
    }

    private void GameOver()
    {
        _gameOverText.SetActive(true);
        _restartButton.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void RestartLevel()
    {
        ScoreManager.Instance.ResetScore();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Redémarrer la scène actuelle
        _restartButton.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
