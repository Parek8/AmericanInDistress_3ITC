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
        if (GameManager.GameManagerInstance.IsPlayerBuilding())
        {
            if (!IsOccupied)
            {
                if (ResourceManager.ResourceManagerInstance.HasEnoughResources(BuildManager.BuildManagerInstance.SelectedBuilding))
                {
                    var cube = Instantiate(BuildManager.BuildManagerInstance.SelectedBuilding.BuiltPrefab);

                    var cmd = new BuildCommand(
                                cube,
                                this
                                );

                    CommandQueue.Instance.AddCommand(cmd);

                    this._builtBuilding = cube;

                    ResourceManager.ResourceManagerInstance.DecreaseResources(BuildManager.BuildManagerInstance.SelectedBuilding);
                }
                else
                    Debug.Log("Not enough resources!");
            }
            else
                Debug.Log("Tile is already occupied!");
        }
    }
}