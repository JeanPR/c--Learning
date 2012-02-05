using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameLoop
{
    class TitleMenuState : IGameObject
    {
        public void Update(double elapsedTime)
        {
            System.Console.WriteLine("Updating TitleMenu");
        }

        public void Render()
        {
            System.Console.WriteLine("Rendering TitleMenu");
        }
    }
}
