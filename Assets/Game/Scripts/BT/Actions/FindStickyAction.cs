using System;
using Unity.Behavior;
using Action = Unity.Behavior.Action;
using Unity.Properties;
using UnityEngine;
using AntSimulation;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "FindTargetSticky", story: "[Agent] [AntView] Find Free [Sticky]", category: "Action", id: "df4ed9c17947f23e7039c7cd98e35038")]
public partial class FindStickyAction : Action
{
    [SerializeReference] public BlackboardVariable<AntAgent> Agent;
    [SerializeReference] public BlackboardVariable<StickView> Sticky;

    protected override Status OnStart()
    {
        var target = Agent.Value.SticksRepository.GetRandomFreeStick();

        if(target != null)
        {
            Sticky.Value = target;
        }

        return Status.Running;
    }
}