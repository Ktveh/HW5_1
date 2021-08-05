using UnityEngine;

public class Follow : MonoBehaviour
{
    [SerializeField] private GameObject _player;

    private Vector3 _offset;

    private void Awake()
    {
        _offset = transform.position - _player.transform.position;
    }

    private void Update()
    {
        transform.position = _player.transform.position + _offset;
    }
}
