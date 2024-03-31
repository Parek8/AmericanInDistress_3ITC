using UnityEngine;

public class UIManager : MonoBehaviour
{
    private static UIManager _UIManagerInstance;
    internal static UIManager UIManagerInstance => _UIManagerInstance;

    [field: SerializeField] GameObject ShopScreen;

    private void Awake()
    {
        if (_UIManagerInstance== null)
            _UIManagerInstance = this;
    }

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