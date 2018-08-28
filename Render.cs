namespace CSharpGameTest.Interfaces
{
    public interface IRender
    {
        int FramesPerSecond {get; set;}
         void Render();
    }
}