using SimCorp.IMS.Fake;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.MobilePhoneLibrary.General;
using SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents.Charger;

namespace SimCorp.IMS.Test.ChargerTests {
    [TestClass]
    public class TestOutputForSamsungCharger {
        [TestMethod]
        public void SamsungCharger_IsInProgress() {
            // Arrange / Act
            IOutput output = new OutputMock();
            ICharger charger = new SamsungCharger(output);
            charger.Charge(output);

            var expectedString = "SamsungCharger in progress\r\n";

            //Assert
            Assert.AreEqual(expectedString, output.Output.ToString());
        }
    }
}
