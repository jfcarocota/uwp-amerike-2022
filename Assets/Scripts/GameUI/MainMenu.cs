using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    Button btnNewGame;
    [SerializeField]
    Button btnLoadGame;
    [SerializeField]
    Button btnQuit;
    [SerializeField]
    GameObject newGamePanel;

    void Awake()
    {
        btnNewGame.onClick.AddListener(ShowNewGamePanel);
        btnLoadGame.onClick.AddListener(LoadGameData);
    }

    IEnumerator Start()
    {
        yield return new WaitForSeconds(3f);
        FileInfo[] gameFiles = Memorysystem.GetGameFiles();
        foreach(FileInfo gameFile in gameFiles)
        {
            Debug.Log(Path.GetFileNameWithoutExtension(gameFile.Name));
        }
    }

    void ShowNewGamePanel() => newGamePanel.SetActive(true);

    void LoadGameData()
    {
        GameData gameData = Memorysystem.LoadGame("uwu");
        Debug.Log(gameData.GetGameName);
    }
}
