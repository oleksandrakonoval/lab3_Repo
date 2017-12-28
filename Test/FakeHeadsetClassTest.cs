using SimCorp.IMS.Fake;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.MobilePhoneLibrary.General;

namespace SimCorp.IMS.Test {
    [TestClass]
    public class TestOutputForFakeClass {
        [TestMethod]
        public void FakeClassPlayTest() {
            // Arrange / Act
            IOutput output = new OutputMock();
            FakeHeadset headset = new FakeHeadset(output);
            headset.Play(output);

            var expectedString = "iPhoneHeadset sound\r\n";
            
            //Assert
            Assert.AreEqual(expectedString, output.Output.ToString());
        }        
    }
}
