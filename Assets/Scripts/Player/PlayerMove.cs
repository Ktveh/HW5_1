using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _angle;
    [SerializeField] private float _speed;

    public void Rotate(float direction)
    {
        float angle = _angle * direction;
        transform.Rotate(0, 0, angle * Time.deltaTime);
    }

    public void Walk(float direction)
    {
        float speed = _speed * direction;
        transform.Translate(0, speed * Time.deltaTime, 0);
    }
}
