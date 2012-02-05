using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameLoop
{
    class SplashScreenState : IGameObject
    {

        StateSystem _system;

        public SplashScreenState(StateSystem system)
        {
            _system = system;
        }

        public void Update(double elapsedTime)
        {
            System.Console.WriteLine("Updating Splash");
        }

        public void Render()
        {
            System.Console.WriteLine("Rendering Splash");
        }
    }
}
