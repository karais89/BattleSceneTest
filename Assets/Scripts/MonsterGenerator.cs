using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MonsterGenerator : MonoBehaviour 
{
    public static readonly int      MAX_MONSTER     = 5;
    
    [SerializeField]
    private GameObject              _monsterPrefab;

    private List<MonsterControl>    _monsterControls = new List<MonsterControl>();
    
    public List<MonsterControl>     MonsterControls
    {
        get { return _monsterControls; }
    }

    void Awake()
    {
        MakeMonster();
    }


    private void MakeMonster()
    {
        GameObject g = Instantiate(_monsterPrefab, new Vector2(4, 0), Quaternion.identity) as GameObject;
        _monsterControls.Add( g.GetComponent<MonsterControl>() );
        
        g = Instantiate(_monsterPrefab, new Vector2(3, 0), Quaternion.identity) as GameObject;
        _monsterControls.Add(g.GetComponent<MonsterControl>());
    }
}
