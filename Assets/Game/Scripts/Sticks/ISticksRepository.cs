namespace AntSimulation
{
    public interface ISticksRepository
    {
        void Add(StickView view);
        StickView GetRandomFreeStick();
        void RemoveStickIsFree(StickView view);
        public int GetCount();
    }
}