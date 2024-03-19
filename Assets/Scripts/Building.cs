using UnityEngine;

public class Building : ScriptableObject
{
   [field: SerializeField] public int RequiredCoins { get; private set; }
   [field: SerializeField] public int RequiredLogs { get; private set; }
   [field: SerializeField] public GameObject BuiltPrefab { get; private set; }
}