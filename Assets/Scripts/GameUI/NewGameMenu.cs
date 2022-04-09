using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;
using System.IO;


public class NewGameMenu : MonoBehaviour
{
    [SerializeField]
    TMP_InputField inputGameName;
    [SerializeField]
    Button btnCreateNewGame;
    [SerializeField]
    Button btnCancel;

    string gameName;

    void Awake()
    {
        inputGameName.onEndEdit.AddListener(value => ChangeValueAtEnd(value));
        btnCreateNewGame.onClick.AddListener(CreateNewGame);
        btnCancel.onClick.AddListener(Cancel);
    }

    void ChangeValueAtEnd(string gameName) => this.gameName = gameName;

    void CreateNewGame()
    {
        if(ValidGameName)
        {
            Memorysystem.NewGame(gameName);
        }
    }

    void Cancel() => gameObject.SetActive(false);

    bool ValidGameName => !String.IsNullOrEmpty(gameName);
}
