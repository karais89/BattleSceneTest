﻿using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour 
{
    public static GameManager Instance
    {
        get;
        private set;
    }
    
    void Awake()
    {
        Instance = this;
    }
}
