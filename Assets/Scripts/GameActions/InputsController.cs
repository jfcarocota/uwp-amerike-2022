using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Contexts;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputsController : MonoBehaviour
{
    GameActions gameActions;

    void Awake()
    {
        gameActions = new GameActions();
    }

    void Start()
    {
        gameActions.Gameplay.SaveGame.performed +=  _=> Memorysystem.SaveGame("uwu", new GameData("uwu", 24, 13.14f, 50f));

        //Suscribe un metodo a una accion.
        //gameActions.Gameplay.SaveGame.performed += OtraFuncion;

        //Desuscribir un metodo de la acción
        //gameActions.Gameplay.SaveGame.performed -= OtraFuncion;
    }

    /*void OtraFuncion(InputAction.CallbackContext ctx)
    {
        //Debug.Log("me estoy ejecutando");
        //return GeneradorPerron(5, 2);
    }*/

    void OnEnable()
    {
        gameActions.Enable();
    }

    void OnDisable()
    {
        gameActions.Disable();
    }


}
