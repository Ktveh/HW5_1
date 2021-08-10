using UnityEngine;

[RequireComponent(typeof(Animator), typeof(PlayerInput))]
public class PlayerAnimation : MonoBehaviour
{
    private Animator _animator;
    private PlayerInput _input;

    private void Stop()
    {
        _animator.SetBool("Walk", false);
    }

    private void Move()
    {
        _animator.SetBool("Walk", true);
    }

    private void OnEnable()
    {
        _input.Went.AddListener(Move);
        _input.Stopped.AddListener(Stop);
    }

    private void OnDisable()
    {
        _input.Went.RemoveListener(Move);
        _input.Stopped.RemoveListener(Stop);
    }

    private void Awake()
    {
        _input = GetComponent<PlayerInput>();
        _animator = GetComponent<Animator>();
    }
}
