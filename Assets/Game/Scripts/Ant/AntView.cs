using Unity.Behavior;
using UnityEngine;
using UnityEngine.AI;

namespace AntSimulation
{
    public class AntView : MonoBehaviour
    {
        [field: SerializeField] public NavMeshAgent NavMeshAgent { get; private set; }
        [field: SerializeField] public BehaviorGraphAgent BehaviorGraphAgent { get; private set; }
        [field: SerializeField] public bool HasStick { get; private set; }

        private Transform _object;

        public void TakeObject(Transform value)
        {
            _object = value;
            _object.parent = transform;
            _object.localPosition = new Vector3(0, 0.5f, 0);
            HasStick = true;
        }

        public void DropObject()
        {
            _object.parent = null;
            _object.position = transform.position;
            HasStick = false;
        }
    }
}