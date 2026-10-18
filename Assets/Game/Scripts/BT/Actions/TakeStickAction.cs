using AntSimulation;
using System;
using Unity.Behavior;
using Unity.Properties;
using UnityEngine;
using Action = Unity.Behavior.Action;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "TakeStick", story: "[Agent] [View] Take [Stick]", category: "Action", id: "90325b625fb321997c57494cb2e48d94")]
public partial class TakeStickAction : Action
{
    [SerializeReference] public BlackboardVariable<AntAgent> Agent;
    [SerializeReference] public BlackboardVariable<AntView> View;
    [SerializeReference] public BlackboardVariable<StickView> Stick;

    protected override Status OnStart()
    {
        View.Value.TakeObject(Stick.Value.transform);
        Agent.Value.SticksRepository.RemoveStickIsFree(Stick.Value);

        return Status.Running;
    }
}