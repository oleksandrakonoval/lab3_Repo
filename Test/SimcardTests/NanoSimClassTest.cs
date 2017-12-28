using SimCorp.IMS.Fake;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.MobilePhoneLibrary.General;
using SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents.Simcard;

namespace SimCorp.IMS.Test.SimcardTests {
    [TestClass]
    public class TestOutputForNanoSim {
        [TestMethod]
        public void NanoSim_IsCall() {
            // Arrange / Act
            IOutput output = new OutputMock();
            ISimCard simcard = new NanoSim(output);
            simcard.Call(output);

            var expectedString = "NanoSim call";
            var myOutput = output.Output.ToString();

            //Assert
            Assert.AreNotEqual(expectedString, myOutput);
            Assert.IsTrue(myOutput.Contains(expectedString));
        }
    }
}

