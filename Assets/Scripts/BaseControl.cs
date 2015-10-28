using UnityEngine;
using System.Collections;

public abstract class BaseControl : MonoBehaviour 
{
    protected Animator          _animator;
    protected Transform         _transofrm;
    protected SpriteRenderer    _spriteRenderer;
    protected virtual void Awake()
    {
        _animator       = GetComponent<Animator>();
        _transofrm      = GetComponent<Transform>();
        _spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

}
