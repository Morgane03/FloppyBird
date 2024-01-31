using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField]
    private GameObject gameOverText;
    private bool isGameOver = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (!isGameOver)
        {
            isGameOver = true;
            GameOver();
        }
    }

    private void GameOver()
    {
        gameOverText.SetActive(true);
        ScoreManager.Instance.ResetScore();
        RestartLevel();
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Redémarrer la scène actuelle
    }
}
