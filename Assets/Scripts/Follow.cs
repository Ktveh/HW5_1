using UnityEngine;

public class Follow : MonoBehaviour
{
    [SerializeField] private GameObject _player;

    private Vector3 _offset;

    void Start()
    {
        _offset = transform.position - _player.transform.position;
    }

    void Update()
    {
        transform.position = _player.transform.position + _offset;
    }
}
