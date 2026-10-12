using UnityEngine;
using Zenject;

namespace AntSimulation
{
    public class AntFactory : IAntFactory
    {
        private IAntMoveRepository _moveRepository;
        private AntSO _data;
        private Transform _parent;
        private DiContainer _container;

        public AntFactory(DiContainer container, AntSO data, IAntMoveRepository moveRepository)
        {
            _data = data;
            _container = container;
            _moveRepository = moveRepository;
        }

        public AntView Create()
        {
            if (_parent == null)
                CreateParent();

            Vector3 randomPosition = new(Random.Range(-_data.SpawnSquare, _data.SpawnSquare), 0, Random.Range(-_data.SpawnSquare, _data.SpawnSquare));
            var ant = _container.InstantiatePrefab(_data.Prefab, randomPosition, Quaternion.identity, _parent).GetComponent<AntView>();
            
            var agent = _container.InstantiateComponent<AntAgent>(ant.gameObject);
            ant.BehaviorGraphAgent.SetVariableValue("Ant Agent", agent);
            ant.gameObject.name = "Ant";
            _moveRepository.Add(ant);

            return ant;
        }

        private void CreateParent()
        {
            _parent = new GameObject().transform;
            _parent.name = "Ant Parent";
        }
    }
}