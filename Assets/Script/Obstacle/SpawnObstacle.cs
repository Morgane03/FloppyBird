using System.Collections;
using UnityEngine;
public class SpawnObstacle : MonoBehaviour
{
    [SerializeField]
    private float _height = 2;
    [SerializeField]
    private float _spawnInterval = 4f;
    [SerializeField]
    private Rigidbody _rb;

    private void Start()
    {
        StartCoroutine(SpawnObstacles());
    }

    private IEnumerator SpawnObstacles()
    {
        while (true)
        {
            GameObject obstacle = ObjectPooler.Instance.GetPooledObject();

            if (obstacle != null)
            {
                // Positionner l'obstacle à la bonne position en Y et le réactiver
                obstacle.transform.position = new Vector3(transform.position.x, Random.Range(-_height, _height), 0);
                obstacle.SetActive(true);
            }
            yield return new WaitForSeconds(_spawnInterval);
        }
    }
}
