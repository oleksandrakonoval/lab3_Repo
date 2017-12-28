using SimCorp.IMS.Fake;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.MobilePhoneLibrary.General;
using SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents.Charger;

namespace SimCorp.IMS.Test.ChargerTests {
    [TestClass]
    public class TestOutputForMotoCharger {
        [TestMethod]
        public void MotoCharger_IsInProgress() {
            // Arrange / Act
            IOutput output = new OutputMock();
            ICharger charger = new MotoCharger(output);
            charger.Charge(output);

            var expectedString = "MotoCharger in progress\r\n";

            //Assert
            Assert.AreEqual(expectedString, output.Output.ToString());
        }

    }
}
