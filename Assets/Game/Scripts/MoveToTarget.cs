using AntSimulation;
using UnityEngine;
using UnityEngine.AI;
using Zenject;

public class MoveToTarget : MonoBehaviour
{
    [Inject] public ISticksRepository SticksRepository;
    [SerializeField] private NavMeshAgent _agent;
    [SerializeField] private World _world;
    public Transform Target;

    private void Update()
    {
        if(Target == null) return;

        _agent.SetDestination(Target.position);
        SetRotation();
    }

    private void SetRotation()
    {
        Vector3 direction = _agent.velocity;
        direction.y = 0;

        if (direction.sqrMagnitude > 0)
        {
            float angleY = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            transform.eulerAngles = new(transform.eulerAngles.x, angleY, transform.eulerAngles.z);
        }
    }
}