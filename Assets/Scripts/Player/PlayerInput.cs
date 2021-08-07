using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(PlayerMove))]
public class PlayerInput : MonoBehaviour
{
    [SerializeField] private UnityEvent _went;
    [SerializeField] private UnityEvent _stopped;
    [SerializeField] private PlayerMove _playerMove;

    private void Start()
    {
        _playerMove = GetComponent<PlayerMove>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _playerMove.Rotate(1);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            _playerMove.Rotate(-1);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            _playerMove.Move(1);
            _went?.Invoke();
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            _playerMove.Move(-1);
            _went?.Invoke();
        }
        else
        {
            _stopped?.Invoke();
        }
    }
}
