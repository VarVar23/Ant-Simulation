using UnityEngine;
using Zenject;

namespace AntSimulation
{
    public class Installer : MonoInstaller
    {
        [SerializeField] private SticksSO _sticksSO;
        [SerializeField] private AntSO _antSO;

        public override void InstallBindings()
        {
            BindStick();
            BindAnt();
        }

        private void BindAnt()
        {
            Container.Bind<IAntFactory>().To<AntFactory>().AsSingle();
            Container.Bind<IAntMoveRepository>().To<AntMoveRepository>().AsSingle();
            Container.Bind<AntSO>().FromInstance(_antSO).AsSingle();
            Container.BindInterfacesAndSelfTo<AntController>().AsSingle();
        }

        private void BindStick()
        {
            Container.BindInterfacesAndSelfTo<StickSpawnController>().AsSingle();
            Container.Bind<IStickFactory>().To<StickFactory>().AsSingle();
            Container.Bind<ISticksRepository>().To<SticksRepository>().AsSingle();
            Container.Bind<SticksSO>().FromInstance(_sticksSO).AsSingle();
        }
    }
}
