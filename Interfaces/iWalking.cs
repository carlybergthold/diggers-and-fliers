namespace Animals
{
    public interface IWalking
    {
        string Name { get; set; }
        void Run();
        void Walk();
    }
}