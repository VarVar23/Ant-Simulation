using UnityEngine;

namespace AntSimulation
{
    [CreateAssetMenu(fileName = "SticksSO", menuName = "Scriptable Objects/SticksSO")]
    public class SticksSO : ScriptableObject
    {
        [field: SerializeField] public StickView Prefab { get; private set; }
        [field: SerializeField] public float SpawnSquare { get; private set; }
        [field: SerializeField] public float SpawnTime { get; private set; }
        [field: SerializeField] public int StartCount { get; private set; }
        [field: SerializeField] public int MaxCountSpawned { get; private set; }
    }
}