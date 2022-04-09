using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MainUI : MonoBehaviour
{

    private Button _btnHello;
    private VisualElement _root;

    private void OnEnable()
    {
        _root = GetComponent<UIDocument>().rootVisualElement;
        _btnHello = _root.Q<Button>("btnHello");
        _btnHello.clicked += OnClickBtnHello;
        // kjsdhjksdhk
    }

    private void OnClickBtnHello() => Debug.Log("Say Hello");
}
