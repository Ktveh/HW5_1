using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(PlayerMove))]
public class PlayerInput : MonoBehaviour
{
    private PlayerMove _move;

    public UnityEvent Went;
    public UnityEvent Stopped;

    private void Awake()
    {
        _move = GetComponent<PlayerMove>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _move.Rotate(1);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            _move.Rotate(-1);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            _move.Walk(1);
            Went?.Invoke();
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            _move.Walk(-1);
            Went?.Invoke();
        }
        else
        {
            Stopped?.Invoke();
        }
    }
}
