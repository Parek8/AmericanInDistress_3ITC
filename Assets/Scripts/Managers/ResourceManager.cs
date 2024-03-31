using UnityEngine;

internal class ResourceManager : MonoBehaviour
{
    private static ResourceManager _resourceManagerInstance = new ResourceManager();
    internal static ResourceManager ResourceManagerInstance => _resourceManagerInstance;

    internal int Coins { get; private set; } = 0;
    internal int Logs { get; private set; } = 0;

    private ResourceManager() => this.InitializeResourceManager();

    void InitializeResourceManager()
    {
        this.Coins = 500;
        this.Logs = 200;
    }

    internal void DecreaseResources(Building BuiltBuilding)
    {
        this.Coins -= BuiltBuilding.RequiredCoins;
        this.Logs -= BuiltBuilding.RequiredLogs;
    }

    internal bool HasEnoughResources(Building BuiltBuilding) => ((this.Coins >= BuiltBuilding.RequiredCoins) && (this.Logs >= BuiltBuilding.RequiredLogs));
}