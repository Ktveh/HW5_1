using System.Collections;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Invisible : MonoBehaviour
{
    [SerializeField] private float _targetAlpha;
    [SerializeField] private float _speedChangeAlpha;
    
    private Coroutine _setAlhpaColorJob;
    private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartSetAlphaColor(_targetAlpha);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        StartSetAlphaColor(1);
    }

    private void StartSetAlphaColor(float targetValue)
    {
        if (_setAlhpaColorJob != null)
            StopCoroutine(_setAlhpaColorJob);
        _setAlhpaColorJob = StartCoroutine(SetAlphaColor(targetValue));
    }

    private IEnumerator SetAlphaColor(float targetValue)
    {
        Color color = _spriteRenderer.color;
        while (color.a != targetValue)
        {
            color.a = Mathf.MoveTowards(color.a, targetValue, _speedChangeAlpha * Time.deltaTime);
            _spriteRenderer.color = color;
            yield return null;
        }
    }
}
