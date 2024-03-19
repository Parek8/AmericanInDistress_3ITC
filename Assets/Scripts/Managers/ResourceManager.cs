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

    internal void DecreaseResources(int decreasedCoins = 0, int decreasedLogs = 0)
    {
        this.Coins -= decreasedCoins;
        this.Logs -= decreasedLogs;
    }

    internal bool HasEnoughResources(int decreasedCoins = 0, int decreasedLogs = 0) => ((this.Coins <= decreasedCoins) && (this.Logs <= decreasedLogs));
}