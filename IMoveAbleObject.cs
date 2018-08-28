namespace CSharpGameTest.Interfaces
{
    public interface IMoveableObject : IGameObject
    {
        void MoveForward();

        void MoveBackward();
        
        void MoveRight();

        void MoveLeft();
    }
}