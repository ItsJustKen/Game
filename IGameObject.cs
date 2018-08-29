namespace Game.Interfaces
{
    public interface IGameObject
    {
        int x {get; set;}

        int y {get; set;}

        int height {get; set;}

        int weight {get; set;}

        string texture {get;}
        
        bool collide(IGameObject obj);

        
    }
}