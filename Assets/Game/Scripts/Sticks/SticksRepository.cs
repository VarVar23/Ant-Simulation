using System.Collections.Generic;
using UnityEngine;

namespace AntSimulation
{
    public class SticksRepository : ISticksRepository
    {
        private List<StickView> _freeSticks = new();

        public void Add(StickView view)
        {
            _freeSticks.Add(view);
        }

        public void RemoveStickIsFree(StickView view)
        {
            _freeSticks.Remove(view);
            view.IsFree = false;
        }

        public int GetCount()
        {
            return _freeSticks.Count;
        }

        public StickView GetRandomStick()
        {
            if (_freeSticks.Count == 0) return null;

            return _freeSticks[Random.Range(0, _freeSticks.Count)];
        }
    }
}