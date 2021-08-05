using UnityEngine;

[RequireComponent(typeof(PlayerAnimation))]
public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _angle;
    [SerializeField] private float _speed;

    private PlayerAnimation _playerAnimation;

    private void Awake()
    {
        _playerAnimation = GetComponent<PlayerAnimation>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Rotate(_angle);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Rotate(-_angle);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            Move(_speed);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            Move(-_speed);
        }
        else
        {
            _playerAnimation.Stop();
        }
    }

    private void Rotate(float angle)
    {
        transform.Rotate(0, 0, angle * Time.deltaTime);
    }

    private void Move(float speed)
    {
        transform.Translate(0, speed * Time.deltaTime, 0);
        _playerAnimation.Move();
    }
}
