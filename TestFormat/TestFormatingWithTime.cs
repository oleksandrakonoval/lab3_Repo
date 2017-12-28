using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.SMSReceiverWFA;
using static SimCorp.IMS.SMSReceiverWFA.Format;

namespace SimCorp.IMS.TestFormat {
    [TestClass]
    public class TestFormatingWithTime {
        [TestMethod]
        public void TestFormating0() {
            // Arrange
            Format format = new Format();
            FormatDelegate currentFormat;
            currentFormat = format.FormatType[0];

            //Act
            string unformatedText = "New message";
            string expectedString = unformatedText;
            format.OnSMSReceived(unformatedText, currentFormat);

            //Assert
            Assert.AreEqual(expectedString, format.OnSMSReceived(unformatedText, currentFormat));
        }
    }
}
