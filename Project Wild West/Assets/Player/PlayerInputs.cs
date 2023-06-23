using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerInputs : MonoBehaviour
{
    public InputActions playerInputActions;
    public InputAction move;
    public InputAction enterCombat;


    [HideInInspector] public bool holdingEnterCombat;

    private void Awake()
    {
        playerInputActions = new InputActions();
    }
    private void Update()
    {
        enterCombat.performed += (c) => { holdingEnterCombat = true; };
        enterCombat.canceled += (c) => { holdingEnterCombat = false; };
    }
    private void OnEnable()
    {
        move = playerInputActions.Player.Move;
        enterCombat = playerInputActions.Player.EnterCombat;
        move.Enable();
        enterCombat.Enable();
    }

    private void OnDisable()
    {
        move.Disable();
        enterCombat.Disable();
    }
}
