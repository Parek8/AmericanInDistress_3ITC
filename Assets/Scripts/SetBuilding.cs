using UnityEngine;

public class SetBuilding : MonoBehaviour
{
    [field: SerializeField] Building BuiltBuilding;
    public void AssignBuilding()
    {
        BuildManager.BuildManagerInstance.SetBuilding(BuiltBuilding);
    }

    private void Update()
    {
        //TODO VÝPIS 
    }
}