using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class Memorysystem
{
    public static void NewGame(string gameName)
    {
        string path = Path.Combine(Application.persistentDataPath, gameName + ".data");
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(path);
        bf.Serialize(file, new GameData(gameName, 1, 74.5f, 5f));
        file.Close();
        Debug.Log(path);
    }

    public static void SaveGame(string gameName, GameData gameData)
    {
        string path = Path.Combine(Application.persistentDataPath, gameName + ".data");
        if(File.Exists(path))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Create(path);
            bf.Serialize(file, gameData);
            file.Close();
            Debug.Log(path);
        }
        else
        {
            Debug.LogWarning($"Couldn't find the path: {path}");
        }
    }

    public static GameData LoadGame(string gameName)
    {
        string path = Path.Combine(Application.persistentDataPath, gameName + ".data");
        if(File.Exists(path))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.OpenRead(path);
            GameData gameData = (GameData) bf.Deserialize(file);
            file.Close();
            return gameData;
            //bf.Serialize(file, gameData);
            //file.Close();
            //Debug.Log(path);
        }

        return null;
    }

    public static FileInfo[] GetGameFiles() => new DirectoryInfo(Application.persistentDataPath + "/").GetFiles("*.data*");
}

