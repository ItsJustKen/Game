using System;
using System.Linq;
using System.Collections.Generic;
using CSharpGameTest.Interfaces;
using CSharpGameTest.Implementations;

namespace CSharpGameTest.Implementations
{
    public class ConsoleRender : IRender
    {

        public int FramesPerSecond {get; set;}
        public void Render(){
            while (true)
            {
                System.Console.WriteLine("Render lol");
            }
        }
    }
}