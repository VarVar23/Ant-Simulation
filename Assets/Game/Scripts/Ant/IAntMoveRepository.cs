using UnityEngine;

namespace AntSimulation
{
    public interface IAntMoveRepository
    {
        void Add(AntView view);
        void Move();
        void Remove(AntView view);
        void SetTarget(AntView view, Transform target);
    }
}