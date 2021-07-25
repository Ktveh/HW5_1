using UnityEngine;

public class Exit : MonoBehaviour
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
        if (!_animator.GetBool("Alarm"))
        {
            if (_audioSource.volume > 0)
            {
                _audioSource.volume = Mathf.MoveTowards(_audioSource.volume, 0, 0.2f * Time.deltaTime);
            }
            else
            {
                _audioSource.Stop();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (_animator.GetBool("Alarm"))
        {
            _animator.SetBool("Alarm", false);
        }
    }
}
