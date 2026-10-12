using UnityEngine;

namespace AntSimulation
{
    [CreateAssetMenu(menuName = "Config/AntSO", fileName = "AntSO", order = 0)]
    public class AntSO : ScriptableObject
    {
        [field: SerializeField] public AntView Prefab { get; private set; }
        [field: SerializeField] public float SpawnSquare { get; private set; }
        [field: SerializeField] public int StartCount { get; private set; }
    }
}