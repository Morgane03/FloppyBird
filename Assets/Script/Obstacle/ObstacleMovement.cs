using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    // Vitesse de déplacement de l'obstacle
    [SerializeField]
    private float _speed;

    private void Update()
    {
        transform.position += Vector3.left * _speed * Time.deltaTime;
    }
}
