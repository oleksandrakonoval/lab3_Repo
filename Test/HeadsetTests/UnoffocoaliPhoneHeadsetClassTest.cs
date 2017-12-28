using SimCorp.IMS.Fake;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.MobilePhoneLibrary.General;
using SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents.Headset;

namespace SimCorp.IMS.Test.HeadsetTests {
    [TestClass]
    public class TestOutputForUnoffocoaliPhoneHeadset {
        [TestMethod]
        public void UnoffocoaliPhoneHeadset_IsPlay() {
            // Arrange / Act
            IOutput output = new OutputMock();
            IPlayback playback = new UnoffocoaliPhoneHeadset(output);
            playback.Play(output);

            //Assert
            Assert.IsTrue(output.Output.ToString().Contains("UnoffocoaliPhoneHeadset"));
        }
    }
}

