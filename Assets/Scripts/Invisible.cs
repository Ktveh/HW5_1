using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invisible : MonoBehaviour
{
    [SerializeField] private float _alpha;

    private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _spriteRenderer.color = new Color(_spriteRenderer.color.r, 
            _spriteRenderer.color.g, _spriteRenderer.color.b, _alpha);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _spriteRenderer.color = new Color(_spriteRenderer.color.r,
            _spriteRenderer.color.g, _spriteRenderer.color.b, 1);
    }
}
