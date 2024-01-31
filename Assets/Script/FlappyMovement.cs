using UnityEngine;

public class FlappyMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _force;
    [SerializeField]
    private float _rotationSpeed = 2;
    private Rigidbody _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        GetPlayerInput();
        RotateBird();
    }

    private void GetPlayerInput()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                ImpulseBird();
            }
        }
        else if (Input.GetKey(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            ImpulseBird();
        }
    }

    private void ImpulseBird()
    {
        _rb.velocity = Vector2.zero;
        _rb.AddForce(Vector2.up * _force);
    }

    private void RotateBird()
    {
        transform.rotation = Quaternion.Euler(0, 0, _rb.velocity.y * _rotationSpeed);
    }
}
