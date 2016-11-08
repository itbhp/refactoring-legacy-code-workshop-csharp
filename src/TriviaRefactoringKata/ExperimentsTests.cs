﻿using System;
using System.IO;
using Xunit;

namespace Trivia
{
    public class ExperimentsTests
    {
        [Fact]
        public void Blah()
        {
            using (var writer = File.CreateText("output1.txt"))
            {
                Console.SetOut(writer);
                var runner = new TestableGameRunner();
                runner.Run();
            }
        }

        class TestableGameRunner : GameRunner
        {
            
        }
    }
}