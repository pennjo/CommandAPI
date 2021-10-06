using System;
using Xunit;
using CommandAPI.Models;

namespace CommandAPI.Tests
{
    public class CommandTests : IDisposable
    {
        Command testCommand;
        public CommandTests()
        {
            testCommand = new Command
            {
                HowTo = "Do something",
                Platform = "Some platform",
                CommandLine = "Some commandline"
            };
        }
        public void Dispose()
        {
            testCommand = null;
        }

        [Fact]
        public void CanChangeHowTo()
        {
            //Arrange
            // var testCommand = new Command
            // {
            //     HowTo = "Do something awesome",
            //     Platform = "xUnit",
            //     CommandLine = "dotnet test"
            // };
            // Use Constructor CommandTests and Dispose instead           

            //Act
            testCommand.HowTo = "Execute Unit Tests";
            //Assert
            Assert.Equal("Execute Unit Tests", testCommand.HowTo);
            // Assert.Equal("Test Fail", testCommand.HowTo);

        }

        [Fact]
        public void CanChangePlatform()
        {
            //Arrange
            // Use Constructor and Dispose            
            //Act
            testCommand.Platform = "NUnit";
            //Assert
            Assert.Equal("NUnit", testCommand.Platform);

        }

        [Fact]
        public void CanChangeCommandLine()
        {
            //Arrange
            // Use Constructor and Dispose            
            //Act
            testCommand.CommandLine = "test";
            //Assert
            Assert.Equal("test", testCommand.CommandLine);

        }

    }
}