using System;
using System.Linq;
using System.Collections.Generic;
using CSharpGameTest.Interfaces;
using CSharpGameTest.Implementations;

namespace CSharpGameTest
{
    public interface IGameController
    {
        List<object> Tasks {get;set;}

        void Update();
    }
}