namespace DI3
{

    public interface IPlayerMover
    {
        void SetDependencies(UserInput userInput, ComputerInput computerInput, Rigidbody2D rb);
    }
}