using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.SMSReceiverWFA;
using System;
using static SimCorp.IMS.SMSReceiverWFA.Format;

namespace SimCorp.IMS.TestFormat {
    [TestClass]
    public class TestFormatingLowercase {
        [TestMethod]
        public void TestFormating4() {
            // Arrange
            Format format = new Format();
            FormatDelegate currentFormat;
            currentFormat = format.FormatType[4];

            //Act
            string unformatedText = "New message";
            string expectedString = unformatedText.ToLower();
            format.OnSMSReceived(unformatedText, currentFormat);

            //Assert
            Assert.AreEqual(expectedString, format.OnSMSReceived(unformatedText, currentFormat));
        }
    }
}
