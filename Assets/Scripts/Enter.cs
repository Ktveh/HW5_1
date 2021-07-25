using UnityEngine;

public class Enter : MonoBehaviour
{
    [SerializeField] private GameObject _signaling;

    private AudioSource _audioSource;
    private Animator _animator;

    void Start()
    {
        _audioSource = _signaling.GetComponent<AudioSource>();
        _animator = _signaling.GetComponent<Animator>();
    }

    private void Update()
    {
        if (_animator.GetBool("Alarm"))
        {
            _audioSource.volume = Mathf.MoveTowards(_audioSource.volume, 1, 0.2f * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!_animator.GetBool("Alarm"))
        {
            _animator.SetBool("Alarm", true);
            _audioSource.Play();
            _audioSource.volume = 0;
        }
    }
}
