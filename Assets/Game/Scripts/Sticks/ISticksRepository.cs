namespace AntSimulation
{
    public interface ISticksRepository
    {
        void Add(StickView view);
        StickView GetRandomStick();
        void RemoveStickIsFree(StickView view);
        public int GetCount();
    }
}