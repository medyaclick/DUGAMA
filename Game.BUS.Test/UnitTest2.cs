using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game.BUS;

namespace Game.BUS.Test
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            GameOperations game = new GameOperations(1000);
            var games = game.Get();

        }
    }
}
