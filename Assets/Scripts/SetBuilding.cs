using UnityEngine;

public class SetBuilding : MonoBehaviour
{
    [field: SerializeField] Building BuiltBuilding;
    public void AssignBuilding()
    {
        Debug.Log("ahoj");
        UIManager.UIManagerInstance.Hide();
        BuildManager.BuildManagerInstance.SetBuilding(BuiltBuilding);
        GameManager.GameManagerInstance.SetPlayerState(PlayerStates.Building);
    }
}