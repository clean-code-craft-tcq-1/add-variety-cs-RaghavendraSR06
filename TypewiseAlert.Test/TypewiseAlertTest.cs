using System;
using Xunit;

namespace TypewiseAlert.Test
{
    public class TypewiseAlertTest
    {
        [Fact]
        public void ClassifyTemperatureBreachAsNormal()
        {
            Assert.True(CheckBreachLevel.ClassifyTemperatureBreach(BMSConstants.CoolingType.HiActiveCooling, 40) == BMSConstants.BreachType.Normal);
        }
        [Fact]
        public void ClassifyTemperatureBreachAsLow()
        {
            Assert.True(CheckBreachLevel.ClassifyTemperatureBreach(BMSConstants.CoolingType.PassiveCooling, -1) == BMSConstants.BreachType.TooLow);
        }

        [Fact]
        public void ClassifyTemperatureBreachAsHigh()
        {
            Assert.True(CheckBreachLevel.ClassifyTemperatureBreach(BMSConstants.CoolingType.MedActiveCooling, 90) == BMSConstants.BreachType.TooHigh);
        }

        [Fact]
        public void InfersBreachAsLow()
        {
            Assert.True(CheckBreachLevel.CheckBreachType(12, 20, 30) == BMSConstants.BreachType.TooLow);
        }
        [Fact]
        public void InfersBreachAsHigh()
        {
            Assert.True(CheckBreachLevel.CheckBreachType(40, 20, 30) ==
              BMSConstants.BreachType.TooHigh);
        }

        [Fact]
        public void InfersBreachAsNormal()
        {
            Assert.True(CheckBreachLevel.CheckBreachType(40, 40, 40) ==
              BMSConstants.BreachType.Normal);
        }

        [Fact]
        public void EmailAlertTest()
        {
            var test = new Battery(BMSConstants.CoolingType.PassiveCooling,"test");
            BMSTypeAlert.CheckAndAlert(BMSConstants.AlertTarget.EmailAlert, test, 24);
        }

        [Fact]
        public void ControllerAlertTest()
        {
            var test = new Battery(BMSConstants.CoolingType.PassiveCooling, "test");
            BMSTypeAlert.CheckAndAlert(BMSConstants.AlertTarget.ControllerAlert, test, 24);
        }

        [Fact]
        public void ConsoleAlertTest()
        {
            var test = new Battery(BMSConstants.CoolingType.PassiveCooling, "test");
            BMSTypeAlert.CheckAndAlert(BMSConstants.AlertTarget.ConsoleAlert, test, 24);
        }

        [Fact]
        public void FakeAlertTest()
        {
            var test = new Battery(BMSConstants.CoolingType.PassiveCooling, "test");
            BMSTypeAlert.CheckAndAlert(BMSConstants.AlertTarget.ConsoleAlert, test, 24);
            Assert.True(ConsoleAlert.IsNotified);
        }
    }
}
