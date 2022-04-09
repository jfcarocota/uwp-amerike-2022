using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

[Serializable]
public class GameData
{
    [SerializeField]
    string gameName;
    [SerializeField]
    int level;
    [SerializeField]
    float currentExp;
    [SerializeField]
    float money;

    public GameData(){}

    public GameData(string gameName, int level, float currentExp, float money)
    {
        this.gameName = gameName;
        this.level = level;
        this.currentExp = currentExp;
        this.money = money;
    }

    public string GetGameName => gameName;
}
