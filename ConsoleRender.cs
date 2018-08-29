using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using Game.Interfaces;
using Game.Implementations;

namespace Game.Implementations
{
    public class ConsoleRender : IRender
    {

        public int FramesPerSecond {get; set;}
        public void Render(){
            FramesPerSecond = 30;
            DateTime lastTime;
            while (true)
            {
                lastTime = DateTime.Now;
                Console.WriteLine(Game.gameObjects);
                Console.WriteLine("Render lol");
                System.Console.WriteLine(new TimeSpan(0,0,FramesPerSecond) - (DateTime.Now - lastTime));
                if (DateTime.Now - lastTime < new TimeSpan(0,0,FramesPerSecond))
                {
                    Thread.Sleep((new TimeSpan(0,0,FramesPerSecond) - (DateTime.Now - lastTime)).Seconds);
                }
                    
            }
        }
    }
}