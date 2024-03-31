using UnityEngine;

public class SetBuilding : MonoBehaviour
{
    [field: SerializeField] Building BuiltBuilding;
    public void AssignBuilding()
    {
        UIManager.UIManagerInstance.Hide();
        BuildManager.BuildManagerInstance.SetBuilding(BuiltBuilding);
        GameManager.GameManagerInstance.SetPlayerState(PlayerStates.Building);
    }
}