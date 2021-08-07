using UnityEngine;

public class Follow : MonoBehaviour
{
    [SerializeField] private GameObject _target;

    private Vector3 _offset;

    private void Start()
    {
        _offset = transform.position - _target.transform.position;
    }

    private void Update()
    {
        transform.position = _target.transform.position + _offset;
    }
}
