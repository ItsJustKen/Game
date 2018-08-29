using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using Game.Interfaces;
using Game.Implementations;

namespace Game
{
    public interface IGameController
    {
        List<object> tasks {get; set;}
        void Update();


    }
}