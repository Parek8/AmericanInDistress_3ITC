using UnityEngine;

public class SetBuilding : MonoBehaviour
{
    [field: SerializeField] Building BuiltBuilding;
    public void AssignBuilding()
    {
        BuildManager.BuildManagerInstance.SetBuilding(BuiltBuilding);
        UIManager.UIManagerInstance.Hide();
    }

    private void Update()
    {
        //TODO VÝPIS 
    }
}