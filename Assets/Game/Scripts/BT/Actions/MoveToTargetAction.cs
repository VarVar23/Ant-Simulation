using AntSimulation;
using System;
using Unity.Behavior;
using Unity.Properties;
using UnityEngine;
using Action = Unity.Behavior.Action;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "Move To Target", story: "[AntView] Move To [Target]", category: "Action", id: "0d2bde42757c55f088e29c31ddc2abac")]
public partial class MoveToTargetAction : Action
{
    [SerializeReference] public BlackboardVariable<Transform> Target;
    [SerializeReference] public BlackboardVariable<AntView> AntView;

    protected override Status OnStart()
    {
        AntView.Value.NavMeshAgent.SetDestination(Target.Value.position);
        SetRotation();
        return Status.Running;
    }

    private void SetRotation()
    {
        Vector3 direction = AntView.Value.NavMeshAgent.velocity;
        direction.y = 0;

        if (direction.sqrMagnitude > 0)
        {
            float angleY = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
            AntView.Value.transform.eulerAngles = new(AntView.Value.transform.eulerAngles.x, angleY, AntView.Value.transform.eulerAngles.z);
        }
    }
}

