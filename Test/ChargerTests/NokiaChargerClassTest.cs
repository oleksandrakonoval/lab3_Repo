using SimCorp.IMS.Fake;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.MobilePhoneLibrary.General;
using SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents.Charger;

namespace SimCorp.IMS.Test.ChargerTests {
    [TestClass]
    public class TestOutputForNokiaCharger {
        [TestMethod]
        public void NokiaCharger_IsInProgress() {
            // Arrange / Act
            IOutput output = new OutputMock();
            ICharger charger = new NokiaCharger(output);
            charger.Charge(output);

            var expectedString = "NokiaCharger in progress\r\n";

            //Assert
            Assert.AreEqual(expectedString, output.Output.ToString());
        }
    }
}
