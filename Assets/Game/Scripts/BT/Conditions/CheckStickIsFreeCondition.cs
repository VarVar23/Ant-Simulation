using AntSimulation;
using System;
using Unity.Behavior;
using UnityEngine;

[Serializable, Unity.Properties.GeneratePropertyBag]
[Condition(name: "CheckStickyIsFree", story: "Check [StickView] Is Free", category: "Conditions", id: "5d44c64a0e5e063988ef0e8fb9dbbddd")]
public partial class CheckStickIsFreeCondition : Condition
{
    [SerializeReference] public BlackboardVariable<StickView> StickView;

    public override bool IsTrue()
    {
        return StickView.Value.IsFree;
    }
}