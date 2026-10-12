using UnityEngine;

namespace AntSimulation
{
    public class StickFactory : IStickFactory
    {
        private Transform _parent;
        private SticksSO _data;

        public StickFactory(SticksSO data)
        {
            _data = data;
        }

        public StickView Create()
        {
            if (_parent == null)
                CreateParent();

            Vector3 randomPosition = new(Random.Range(-_data.SpawnSquare, _data.SpawnSquare), 0, Random.Range(-_data.SpawnSquare, _data.SpawnSquare));
            Quaternion randomRotation = Quaternion.Euler(0, Random.Range(0, 360), 0);

            var stick = GameObject.Instantiate(_data.Prefab, randomPosition, randomRotation, _parent);
            stick.gameObject.name = "Stick";
            stick.IsFree = true;

            return stick;
        }

        private void CreateParent()
        {
            _parent = new GameObject().transform;
            _parent.name = "Sticks Parent";
        }
    }
}