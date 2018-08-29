namespace Game.Interfaces
{
    public interface IRender
    {
        int FramesPerSecond {get; set;}
         void Render();
    }
}