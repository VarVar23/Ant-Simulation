using AntSimulation;
using System;
using Unity.Behavior;
using UnityEngine;

[Serializable, Unity.Properties.GeneratePropertyBag]
[Condition(name: "CheckTakeStick", story: "[View] Has Take Stick", category: "Conditions", id: "477596499cb39521c0644acc98cca214")]
public partial class CheckTakeStickCondition : Condition
{
    [SerializeReference] public BlackboardVariable<AntView> View;

    public override bool IsTrue()
    {
        return View.Value.HasStick;
    }
}