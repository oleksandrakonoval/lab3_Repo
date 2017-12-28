using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.MobilePhoneLibrary.MobilePhone;
using SimCorp.IMS.SMSReceiverWFA;
using static SimCorp.IMS.SMSReceiverWFA.Format;

namespace SimCorp.IMS.TestEvent {
    [TestClass]
    public class TestFormatingLowercase {
        [TestMethod]
        public void TestEventRaised() {
            // Arrange
            EmptyMobile MyMobile = new EmptyMobile();
            Format format = new Format();
            FormatDelegate currentFormat;
            currentFormat = format.FormatType[0];
            string unformatedText = "New message";
            bool raisedEvent = false;
            MyMobile.SMSProvider = new SMSProvider();

            //Act
            MyMobile.SMSProvider.SMSReceived += (message) => { raisedEvent = true; };
            MyMobile.SMSProvider.ReceiveSMS(format.OnSMSReceived(unformatedText, currentFormat));

            //Assert
            Assert.IsTrue(raisedEvent);
        }
    }
}
