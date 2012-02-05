using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace GameLoop
{
    [TestFixture]
    class Test_StateSystem
    {
        [Test]
        public void TestAddedStateExists()
        {
            StateSystem stateSystem = new StateSystem();
            stateSystem.AddState("splash", new SplashScreenState(stateSystem));

            // Does the added function now exist?

            Assert.IsTrue(stateSystem.Exists("splash"));
        }
    }
}
