using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _gameManagerInstance;
    public static GameManager GameManagerInstance => _gameManagerInstance;
    static PlayerStates PlayerState = PlayerStates.SelectingBuilding;
    private void Awake()
    {
        if (_gameManagerInstance == null)
            _gameManagerInstance = this;
    }

    public void SetPlayerState(PlayerStates state) => PlayerState = state;
    public bool IsPlayerBuilding() => PlayerState == PlayerStates.Building;
    public bool IsPlayerSelectingBuilding() => PlayerState == PlayerStates.SelectingBuilding;
    public bool IsPlayerWaiting() => PlayerState == PlayerStates.Waiting;
}

public enum PlayerStates
{
    SelectingBuilding,
    Building,
    Waiting,
}