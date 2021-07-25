using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _angle;
    [SerializeField] private float _speed;

    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 0, _angle * Time.deltaTime);
            _animator.SetBool("Walk", true);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, _angle * Time.deltaTime * -1);
            _animator.SetBool("Walk", true);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, _speed * Time.deltaTime, 0);
            _animator.SetBool("Walk", true);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, _speed * Time.deltaTime * -1, 0);
            _animator.SetBool("Walk", true);
        }
        else
        {
            _animator.SetBool("Walk", false);
        }
    }
}
