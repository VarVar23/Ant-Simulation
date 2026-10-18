using UnityEngine;
using Zenject;

namespace AntSimulation
{
    public class Installer : MonoInstaller
    {
        [SerializeField] private HomeView _homeView;
        [SerializeField] private SticksSO _sticksSO;
        [SerializeField] private AntSO _antSO;

        public override void InstallBindings()
        {
            BindHome();
            BindStick();
            BindAnt();
        }

        private void BindHome()
        {
            Container.Bind<HomeView>().FromInstance(_homeView).AsSingle();
        }

        private void BindAnt()
        {
            Container.Bind<IAntFactory>().To<AntFactory>().AsSingle();
            Container.Bind<AntSO>().FromInstance(_antSO).AsSingle();
            Container.BindInterfacesAndSelfTo<AntsController>().AsSingle();
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
