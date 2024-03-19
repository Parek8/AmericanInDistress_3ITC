using TMPro;
using UnityEngine;

public class LogChange : MonoBehaviour
{
    [SerializeField]
    TMP_Text text;

    // Update is called once per frame
    void Update()
    {
        text.text = $"{ResourceManager.ResourceManagerInstance.Logs}x";
    }
}