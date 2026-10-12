using System;
using Unity.Behavior;
using Action = Unity.Behavior.Action;
using Unity.Properties;
using UnityEngine;
using AntSimulation;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "FindTargetSticky", story: "[Agent] [AntView] Find [Sticky]", category: "Action", id: "df4ed9c17947f23e7039c7cd98e35038")]
public partial class FindStickyAction : Action
{
    [SerializeReference] public BlackboardVariable<AntAgent> Agent;
    [SerializeReference] public BlackboardVariable<AntView> AntView;
    [SerializeReference] public BlackboardVariable<Transform> Sticky;

    protected override Status OnStart()
    {
        var target = Agent.Value.SticksRepository.GetRandomStick();

        if(target != null)
        {
            Agent.Value.AntMoveRepository.SetTarget(AntView.Value, target.transform);
            Sticky.Value = target.transform;
        }

        return Status.Running;
    }
}