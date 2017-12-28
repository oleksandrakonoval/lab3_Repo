using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.SMSReceiverWFA;
using System;
using static SimCorp.IMS.SMSReceiverWFA.Format;

namespace SimCorp.IMS.TestFormat {
    [TestClass]
    public class TestFormatingUppercase {
        [TestMethod]
        public void TestFormating5() {
            // Arrange
            Format format = new Format();
            FormatDelegate currentFormat;
            currentFormat = format.FormatType[5];

            //Act
            string unformatedText = "New message";
            string expectedString = unformatedText.ToUpper();
            format.OnSMSReceived(unformatedText, currentFormat);

            //Assert
            Assert.AreEqual(expectedString, format.OnSMSReceived(unformatedText, currentFormat));
        }
    }
}
