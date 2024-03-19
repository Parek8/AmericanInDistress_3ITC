using UnityEngine;

public class UIManager : MonoBehaviour
{
    private static UIManager _UIManagerInstance = new UIManager();
    internal static UIManager UIManagerInstance => _UIManagerInstance;

    [field: SerializeField] GameObject ShopScreen;

    public void Show()
    {
        if (ShopScreen != null && !ShopScreen.activeInHierarchy)
            ShopScreen.SetActive(true);
    }
    public void Hide()
    {
        if (ShopScreen != null && ShopScreen.activeInHierarchy)
            ShopScreen.SetActive(false);
    }
}