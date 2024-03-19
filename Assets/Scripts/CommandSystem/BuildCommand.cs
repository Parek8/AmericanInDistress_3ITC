using UnityEngine;
public class BuildCommand : Command
{
    private GameObject buildingPrefab;
    private Tile tile;

    public BuildCommand(GameObject buildingPrefab, Tile tile)
    {
        this.buildingPrefab = buildingPrefab;
        this.tile = tile;
    }

    public override void Execute()
    {
        GameObject building = GameObject.Instantiate(buildingPrefab);
        tile.SetBuilding(building);
    }
}
