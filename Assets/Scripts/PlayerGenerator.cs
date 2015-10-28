using UnityEngine;
using System.Collections;

public class PlayerGenerator : MonoBehaviour 
{
    public static readonly int      PLAYER_COUNT     = 2;
    public static readonly Vector2  SPAWN_POINT      = new Vector2(-2, 0);
    
    [SerializeField]
    private GameObject _playerPrefab;
    


    void Awake()
    {
        MakePlayer(); 
    }

    /// <summary>
    /// 플레이어 생성
    /// </summary>
    private void MakePlayer()
    {
        for(int i = 0; i < PLAYER_COUNT; i++)
        {
            GameObject g = Instantiate(_playerPrefab, SPAWN_POINT + new Vector2(0.2f * i, 0), Quaternion.identity) as GameObject;
        }
    }                
}
