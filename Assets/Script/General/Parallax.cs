using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField]
    private float parallaxSpeed = 1f; // Vitesse de déplacement du fond
    private float width; // Largeur de l'écran

    private void Start()
    {
        width = Screen.width;
    }

    private void Update()
    {
        float moveX = Time.deltaTime * parallaxSpeed;
        transform.position -= new Vector3(moveX, 0f, 0f);

        if (transform.position.x <= -width)
        {
            transform.position += new Vector3(width, 0f, 0f);
        }
    }
}
