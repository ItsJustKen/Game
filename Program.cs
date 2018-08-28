using System;
using System.Linq;
using System.Collections.Generic;
using CSharpGameTest.Interfaces;
using CSharpGameTest.Implementations;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpGameTest
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            IGameObject test = new Player();
            List<IGameObject> test2 = new List<IGameObject>();
            IRender Renderer = new ConsoleRender();
            Thread test3 = new Thread(Renderer.Render);
            test3.Name = "Render";
            test3.Start();
            
        }
    }
}
