using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    PlayerState playerState;
    private void Awake()
    {
        playerState = GetComponent<PlayerState>();
    }

    private void Update()
    {
        if(playerState.currentState == PlayerState.CurrentState.Combat)
        {
            GetComponent<SpriteRenderer>().color = Color.red;
        }
        else GetComponent<SpriteRenderer>().color = Color.white;
    }
}
