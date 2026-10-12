using UnityEngine;

namespace AntSimulation
{
    public interface IAntMoveService
    {
        void Move();
        void SetTarget(Transform target);
    }
}