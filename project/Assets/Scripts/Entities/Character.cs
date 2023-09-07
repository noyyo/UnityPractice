using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEditor.Animations;
using UnityEngine;

public class Character : MonoBehaviour
{
    public string Name { get; private set; }
    private TextMeshProUGUI _namePlate;
    private SpriteRenderer _spriteRenderer;
    private Animator _animator;

    private void Awake()
    {
        _namePlate = GetComponentInChildren<TextMeshProUGUI>();
        _spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        _animator = GetComponentInChildren<Animator>();
    }
    public void SetName(string name)
    {
        Name = name;
        _namePlate.text = name;
        _namePlate.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, name.Length * 30);
    }
    public void SetSprite(Sprite sprite)
    {
        _spriteRenderer.sprite = sprite;
        
    }
    public void SetAnimatorController(AnimatorController animatorController)
    {
        _animator.runtimeAnimatorController = animatorController;
    }
}
