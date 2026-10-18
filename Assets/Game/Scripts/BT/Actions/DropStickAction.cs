using AntSimulation;
using System;
using Unity.Behavior;
using Unity.Properties;
using UnityEngine;
using Action = Unity.Behavior.Action;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "Drop Stick", story: "[View] Drop Stick", category: "Action", id: "6dc45375b7fba79aff3ea9b6430e2998")]
public partial class DropStickAction : Action
{
    [SerializeReference] public BlackboardVariable<AntView> View;

    protected override Status OnStart()
    {
        View.Value.DropObject();
        return Status.Running;
    }
}