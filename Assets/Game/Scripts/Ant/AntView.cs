using Unity.Behavior;
using UnityEngine;
using UnityEngine.AI;

namespace AntSimulation
{
    public class AntView : MonoBehaviour
    {
        [field: SerializeField] public NavMeshAgent NavMeshAgent { get; private set; }
        [field: SerializeField] public BehaviorGraphAgent BehaviorGraphAgent { get; private set; }
    }
}