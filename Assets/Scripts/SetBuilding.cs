using UnityEngine;

public class SetBuilding : MonoBehaviour
{
    [field: SerializeField] Building BuiltBuilding;
    public void AssignBuilding()
    {
        UIManager.UIManagerInstance.HideBuildSelector();
        BuildManager.BuildManagerInstance.SetBuilding(BuiltBuilding);
        GameManager.GameManagerInstance.SetPlayerState(PlayerStates.Building);
    }
}