using UnityEngine;

public class Tile : MonoBehaviour
{
    public TileData TileData { get; set; }

    private GameObject _builtBuilding = null;
    public bool IsOccupied => (_builtBuilding != null);

    internal void SetBuilding(GameObject building)
    {
        building.transform.SetParent(transform);
        building.transform.localPosition = Vector3.zero;
    }

    private void OnMouseDown()
    {
        if (!IsOccupied)
        {
            if (ResourceManager.ResourceManagerInstance.HasEnoughResources(BuildManager.BuildManagerInstance.SelectedBuilding.RequiredCoins, BuildManager.BuildManagerInstance.SelectedBuilding.RequiredLogs))
            {
                var cube = Instantiate(BuildManager.BuildManagerInstance.SelectedBuilding.BuiltPrefab);

                var cmd = new BuildCommand(
                            cube,
                            this
                            );

                CommandQueue.Instance.AddCommand(cmd);

                this._builtBuilding = cube;
            }
            else
                Debug.Log("Not enough resources!");
        }
        else
            Debug.Log("Tile is already occupied!");
    }
}