using Zenject;

namespace AntSimulation
{
    public class AntsController : IInitializable
    {
        private IAntFactory _factory;
        private AntSO _data;

        public AntsController(IAntFactory factory, AntSO data)
        {
            _factory = factory;
            _data = data;
        }

        public void Initialize()
        {
            for(int i = 0; i < _data.StartCount; i++)
            {
                _factory.Create();
            }
        }
    }
}