using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayerAnimation : MonoBehaviour
{
    private Animator _animator;

    public void Stop()
    {
        _animator.SetBool("Walk", false);
    }

    public void Move()
    {
        _animator.SetBool("Walk", true);
    }

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }
}
