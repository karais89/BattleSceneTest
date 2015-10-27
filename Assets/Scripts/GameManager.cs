using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour 
{
    public static GameManager Instance
    {
        get { return _instance; }
    }
    private static GameManager _instance;

    void Awake()
    {
        _instance = this;
    }

}
