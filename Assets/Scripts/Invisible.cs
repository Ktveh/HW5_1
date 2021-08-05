using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Invisible : MonoBehaviour
{
    [SerializeField] private float _alpha;

    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SetAlphaColor(_alpha);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        SetAlphaColor(1);
    }

    private void SetAlphaColor(float alpha)
    {
        Color color = _spriteRenderer.color;
        _spriteRenderer.color = new Color(color.r, color.g, color.b, alpha);
    }
}
