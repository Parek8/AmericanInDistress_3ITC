using System.Runtime.CompilerServices;

internal class BuildManager
{
    private static BuildManager _buildManagerInstance = new BuildManager();
    internal static BuildManager BuildManagerInstance => _buildManagerInstance;

    internal Building SelectedBuilding { get; private set; }

    internal void SetBuilding(Building setBuilding)
    {
        this.SelectedBuilding = setBuilding;
    }
}