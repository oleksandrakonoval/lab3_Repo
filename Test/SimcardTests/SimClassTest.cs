using SimCorp.IMS.Fake;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.MobilePhoneLibrary.General;
using SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents.Simcard;

namespace SimCorp.IMS.Test.SimcardTests {
    [TestClass]
    public class TestOutputForSim {
        [TestMethod]
        public void Sim_IsCall() {
            // Arrange / Act
            IOutput output = new OutputMock();
            ISimCard simcard = new Sim(output);
            simcard.Call(output);

            var expectedString = "Sim call";
            var myOutput = output.Output.ToString();

            //Assert
            Assert.AreNotEqual(expectedString, myOutput);
            Assert.IsTrue(myOutput.Contains(expectedString));
        }
    }
}

