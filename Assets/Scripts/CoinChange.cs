using TMPro;
using UnityEngine;

public class CoinChange : MonoBehaviour
{
    [SerializeField]
     TMP_Text text;

    // Update is called once per frame
    void Update()
    {
        text.text = $"{ResourceManager.ResourceManagerInstance.Coins}x";
    }
}