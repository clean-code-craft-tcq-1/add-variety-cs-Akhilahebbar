using System;
using Xunit;
using static TypewiseAlert.Constants;

namespace TypewiseAlert.Test
{
    public class TypewiseAlertTest
    {
        [Fact]
        public void FakeAlertTest()
        {
            var test = new BatteryCharacter(Constants.CoolingType.ActivePassiveCooling, "test");
            TypewiseAlert alert = new TypewiseAlert("FakeAlert");
            alert.CheckAndAlert(test, 24);
            FakeAlert notify = alert._alerter as FakeAlert;
            Assert.True(notify.ExecutedAtLeastOnce);
        }
        [Fact]
        public void TestInferBreachAsHigh()
        {
            Assert.True(TypewiseAlert.InferBreachLevel(76, 26, 56) == Constants.BreachType.TOO_HIGH);
        }
        [Fact]
        public void TestInferBreachAsNormal()
        {
            Assert.True(TypewiseAlert.InferBreachLevel(43, 24, 70) == Constants.BreachType.NORMAL);
        }
        [Fact]
        public void TestInferBreachAsLow()
        {
            Assert.True(TypewiseAlert.InferBreachLevel(1, 43, 100) == Constants.BreachType.TOO_LOW);
        }

        [Fact]
        public void TestTempBreachAsHigh()
        {
            Assert.True(TypewiseAlert.ClassifyTemperatureBreach(Constants.CoolingType.ActiveMedCooling, 78) == Constants.BreachType.TOO_HIGH);
        }

        [Fact]
        public void TestTempBreachAsNormal()
        {
            Assert.True(TypewiseAlert.ClassifyTemperatureBreach(Constants.CoolingType.ActiveHiCooling, 32) == Constants.BreachType.NORMAL);
        }
        [Fact]
        public void TestTempBreachAsLow()
        {
            Assert.True(TypewiseAlert.ClassifyTemperatureBreach(Constants.CoolingType.ActivePassiveCooling, -45) == Constants.BreachType.TOO_LOW);
        }
      


    }
}
