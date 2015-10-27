using UnityEngine;
using System.Collections;

[System.Serializable]
public class PlayerControl : BaseControl 
{
    public enum State
    {
        None,
        Find,
        Move,
        Attack,
        Dead,
    };

    private State _state = State.None;

    private MonsterControl   _target;
    private MonsterGenerator _monsterGenerator;
    private float            _speed = 2.0f;

    protected override void Awake()
    {
        base.Awake();
        _monsterGenerator = GameObject.Find("Generator").GetComponent<MonsterGenerator>();
    }
    
    void Update()
    {
        if(_target == null)
        {
            bool isTarget = false;
            // Find Monster
            foreach(var m in _monsterGenerator.MonsterControls)
            {
                if (m.Targeting == null)
                {
                    isTarget = true;
                    _target = m;
                    m.Targeting = this;
                    break;
                }
            }

            if(!isTarget)
            {
                // 가장 가까운 타겟으로 설정.
                foreach (var m in _monsterGenerator.MonsterControls)
                {
                    _target = m;
                    break;
                }
            }

            _animator.SetBool("Attack", false);
        }
        else
        {
            //Debug.Log("_taget != null");
            
            if(Vector2.Distance(transform.position, _target.transform.position) < 0.8f)
            {
                _animator.SetBool("Attack", true);
            }
            else
            { 
                // move
                transform.position = Vector2.MoveTowards(transform.position,
                    _target.transform.position, _speed * Time.deltaTime);

                _animator.SetBool("Attack", false);
            }

        }
    }

    public void OnAttack()
    {
        Debug.Log("OnAttack");
        _target.Damage(10);
    }
}
