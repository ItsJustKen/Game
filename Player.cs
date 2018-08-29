using System;
using Game.Interfaces;

namespace Game.Implementations
{
    public class Player : IGameObject, IMoveableObject//, IPlayableObject
    {
        public float health {get; set;}

        public int x {get; set;}

        public int y {get; set;}

        public int height {get; set;}

        public int weight {get; set;}

        public string texture {
            get{
                return "";
                } 

        }
        public bool collide(IGameObject obj){
            return false;
        }

        public void MoveForward(){
            this.y ++;
        }

        public void MoveBackward(){
            this.y --;
        }

        public void MoveRight(){
            this.x ++;
        }

        public void MoveLeft(){
            this.x --;
        }
        public void GetDamage(){

        }
    }
}