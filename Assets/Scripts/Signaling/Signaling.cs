using UnityEngine;

[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(Animator))]
public class Signaling : MonoBehaviour
{
    private bool _isOn;
    private AudioSource _audioSource;
    private Animator _animator;

    public void TurnOn()
    {
        if (!_isOn)
        {
            _animator.SetBool("Alarm", true);
            _audioSource.Play();
            _audioSource.volume = 0;
            _isOn = true;
        }
    }

    public void TurnOff()
    {
        if (_isOn)
        {
            _animator.SetBool("Alarm", false);
            _isOn = false;
        }
    }

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        _animator = GetComponent<Animator>();
        _isOn = false;
    }

    private void Update()
    {
        if (_isOn)
        {
            ChangeVolume(1);
        }
        else
        {
            if (_audioSource.volume > 0)
            {
                ChangeVolume(0);
            }
            else
            {
                _audioSource.Stop();
            }
        }
    }

    private void ChangeVolume(float targetValue)
    {
        _audioSource.volume = Mathf.MoveTowards(_audioSource.volume, targetValue, 0.2f * Time.deltaTime);
    }
}
