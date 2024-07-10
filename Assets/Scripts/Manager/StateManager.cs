using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum GameState
{
    initializeEnemies,
    playerTurn,
    enemiesTurn,
    defeat,
    victory,
    reward
}
public class StateManager : MonoBehaviour
{
    public GameState state;

    public void UpdateState(GameState newState)
    {
        state = newState;

        switch (newState)
        {
            case GameState.initializeEnemies:
                break;
            case GameState.playerTurn:
                break;
            case GameState.enemiesTurn:
                break;
            case GameState.defeat:
                break;
            case GameState.victory:
                break;
            case GameState.reward:
                break;
        }
    }

    void IsPlayerTurn()
    {
        Debug.Log("Player Turn");
    }

    public void OnUseCard()
    {
        if (state != GameState.playerTurn)
        {
            return;
        }
    }
}
