using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    private static UIManager _UIManagerInstance;
    internal static UIManager UIManagerInstance => _UIManagerInstance;

    [field: SerializeField] GameObject ShopScreen;
    [field: SerializeField] List<Building> Buildings;
    [field: SerializeField] GameObject BuildingCardPrefab;
    [field: SerializeField] Transform BuildingContentParent;

    private void Awake()
    {
        if (_UIManagerInstance== null)
        {
            _UIManagerInstance = this;

            foreach (Building _building in Buildings)
            {
                Instantiate(BuildingCardPrefab, BuildingContentParent).GetComponent<BuildingCard>();
            }
        }
    }

    public void ShowBuildSelector()
    {
        if (ShopScreen != null && !ShopScreen.activeInHierarchy)
            ShopScreen.SetActive(true);
    }
    public void HideBuildSelector()
    {
        if (ShopScreen != null && ShopScreen.activeInHierarchy)
            ShopScreen.SetActive(false);
    }
}