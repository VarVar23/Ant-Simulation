using Zenject;

namespace AntSimulation
{
    public class AntController : IInitializable, ITickable
    {
        private IAntMoveRepository _moveRepository;
        private IAntFactory _factory;
        private AntSO _data;

        public AntController(IAntFactory factory, AntSO data, IAntMoveRepository moveRepository)
        {
            _factory = factory;
            _data = data;
            _moveRepository = moveRepository;
        }

        public void Initialize()
        {
            for(int i = 0; i < _data.StartCount; i++)
            {
                _factory.Create();
            }
        }

        public void Tick()
        {
            _moveRepository.Move();
        }
    }
}