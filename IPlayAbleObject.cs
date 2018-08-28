namespace CSharpGameTest.Interfaces
{
    public interface IPlayableObject
    {
        item[] inventory{get; set;} 
        
        void MoveForward();

        void MoveBackward();
        
        void MoveRight();

        void MoveLeft();
    }
}