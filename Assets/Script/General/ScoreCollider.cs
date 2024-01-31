using UnityEngine;

public class ScoreCollider : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        ScoreManager.Instance.IncreaseScore();
    }
}
