using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BuildingCard : MonoBehaviour
{
    [SerializeField]
    Building BuildingScriptableObject;
    [SerializeField]
    TMP_Text BuildingNameText;
    [SerializeField]
    TMP_Text BuildingCostText;
    [SerializeField]
    Image BuildingIconImage;
    [SerializeField]
    Sprite BuildingSprite;

    //[field: SerializeField] Button 

    private void Start()
    {
        if(BuildingScriptableObject == null) 
            throw new UnassignedReferenceException();

        if (BuildingNameText == null)
            throw new UnassignedReferenceException();

        if (BuildingCostText == null)
            throw new UnassignedReferenceException();

        if (BuildingIconImage == null)
            throw new UnassignedReferenceException();

        if (BuildingSprite == null)
            throw new UnassignedReferenceException();

        BuildingIconImage.sprite = BuildingSprite;
        BuildingNameText.text = BuildingScriptableObject.BuildingName;
        BuildingCostText.text = $"Logs: {BuildingScriptableObject.RequiredLogs} \n Coins: {BuildingScriptableObject.RequiredCoins}";
    }
}
