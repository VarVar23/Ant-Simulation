using System.Collections.Generic;
using UnityEngine;

namespace AntSimulation
{
    public class AntMoveRepository : IAntMoveRepository
    {
        private Dictionary<AntView, IAntMoveService> _dictionary = new();

        public void Add(AntView view)
        {
            IAntMoveService moveService = new AntMoveService(view);
            _dictionary.Add(view, moveService);
        }

        public void Remove(AntView view)
        {
            _dictionary.Remove(view);
        }

        public void SetTarget(AntView view, Transform target)
        {
            if (_dictionary.TryGetValue(view, out IAntMoveService moveService))
            {
                moveService.SetTarget(target);
            }
        }

        public void Move()
        {
            foreach (var ant in _dictionary)
            {
                ant.Value.Move();
            }
        }
    }
}