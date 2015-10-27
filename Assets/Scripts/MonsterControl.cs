using UnityEngine;
using System.Collections;

[System.Serializable]
public class MonsterControl : BaseControl 
{
    private PlayerControl _targeting;
    public PlayerControl Targeting
    {
        set { _targeting = value; }
        get { return _targeting; }
    }

    public  int              _health = 100;
    private MonsterGenerator _monsterGenerator;

    protected override void Awake()
    {
        base.Awake();
        _monsterGenerator = GameObject.Find("Generator").GetComponent<MonsterGenerator>();
    }

    public override string ToString()
    {
        return "monsterControl : " + gameObject.name;
    }


    public void Damage(int damage)
    {
        _health -= damage;
        if (_health <= 0)
        {
            Debug.Log("Dead");
            _monsterGenerator.MonsterControls.Remove(this);
            Destroy(this.gameObject);
            return;
        }
    }
}
