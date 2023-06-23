using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour
{
    PlayerInputs playerInputs;
    public enum CurrentState {Calm, Combat};
    public CurrentState currentState;

    [HideInInspector] public bool canChangeState;

    private void Awake()
    {
        playerInputs = GetComponent<PlayerInputs>();
    }
    private void Start()
    {
        currentState = CurrentState.Calm;
    }
    private void Update()
    {
        if (playerInputs.holdingEnterCombat) currentState = CurrentState.Combat;
        else currentState = CurrentState.Calm;
    }
}
