using System;
using System.Linq;
using System.Collections.Generic;
using Game.Interfaces;
using Game.Implementations;
using System.Threading;
using System.Threading.Tasks;

namespace Game
{
    static public class Game
    {
        public static IPersistence persistence;

        public static List<IGameObject> gameObjects {get; set;}

        public static IRender render = new ConsoleRender();

        public static IGameController gameController;

        public static void Start(){
            //Thread updater = new Thread(gameController.Update);
            Thread renderer = new Thread(render.Render);
            
            //updater.Start();
            renderer.Start();

        }

    }
}