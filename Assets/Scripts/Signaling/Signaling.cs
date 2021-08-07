using System.Collections;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(Animator))]
public class Signaling : MonoBehaviour
{
    private AudioSource _audioSource;
    private Animator _animator;
    private Coroutine _changeVolumeJob;

    public void TurnOn()
    {
        _animator.SetBool("Alarm", true);
        StartChangeVolume(1);
    }

    public void TurnOff()
    {
        _animator.SetBool("Alarm", false);
        StartChangeVolume(0);
    }

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _animator = GetComponent<Animator>();
        _audioSource.volume = 0;
    }

    private void StartChangeVolume(float targetValue)
    {
        if (_changeVolumeJob != null)
            StopCoroutine(_changeVolumeJob);
        _changeVolumeJob = StartCoroutine(ChangeVolume(targetValue));
    }

    private IEnumerator ChangeVolume(float targetValue)
    {
        if (_audioSource.volume == 0)
            _audioSource.Play();
        while (_audioSource.volume != targetValue)
        {
            _audioSource.volume = Mathf.MoveTowards(_audioSource.volume, targetValue, 0.2f * Time.deltaTime);
            yield return null;
        }
        if (_audioSource.volume == 0)
            _audioSource.Stop();
    }
}
