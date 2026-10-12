using System;
using Unity.Behavior;
using UnityEngine;

[Serializable, Unity.Properties.GeneratePropertyBag]
[Condition(name: "CheckHasTarget", story: "Has [Target]", category: "Conditions", id: "eeeee62aadc1f3a5b51d8a70afee16cb")]
public partial class CheckHasTargetCondition : Condition
{
    [SerializeReference] public BlackboardVariable<Transform> Target;

    public override bool IsTrue()
    {
        return Target.Value != null;
    }

    public override void OnStart()
    {

    }

    public override void OnEnd()
    {

    }
}