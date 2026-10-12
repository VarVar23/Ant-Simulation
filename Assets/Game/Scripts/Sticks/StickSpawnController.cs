using UnityEngine;
using Zenject;

namespace AntSimulation
{
    public class StickSpawnController : IInitializable, ITickable
    {
        private IStickFactory _stickFactory;
        private ISticksRepository _stickRepository;
        private SticksSO _data;
        private float _currentTime;

        public StickSpawnController(IStickFactory stickFactory, ISticksRepository stickRepository, SticksSO data)
        {
            _stickFactory = stickFactory;
            _stickRepository = stickRepository;
            _data = data;
            _currentTime = 0;
        }

        public void Initialize()
        {
            for(int i = 0; i < _data.StartCount; i++)
            {
                Spawn();
            }
        }

        public void Tick()
        {
            _currentTime += Time.deltaTime;

            if (_currentTime < _data.SpawnTime) return; 

            if (_stickRepository.GetCount() < _data.MaxCountSpawned)
            {
                Spawn();
            }
        }

        private void Spawn()
        {
            _stickRepository.Add(_stickFactory.Create());
        }
    }
}

