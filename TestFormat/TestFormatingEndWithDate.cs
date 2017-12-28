using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.SMSReceiverWFA;
using System;
using static SimCorp.IMS.SMSReceiverWFA.Format;

namespace SimCorp.IMS.TestFormat {
    [TestClass]
    public class TestFormatingEndWithDate {
        [TestMethod]
        public void TestFormating2() {
            // Arrange
            Format format = new Format();
            FormatDelegate currentFormat;
            currentFormat = format.FormatType[2];

            //Act
            string unformatedText = "New message";
            string expectedString = $"{unformatedText} [{DateTime.Now}]";
            format.OnSMSReceived(unformatedText, currentFormat);

            //Assert
            Assert.AreEqual(expectedString, format.OnSMSReceived(unformatedText, currentFormat));
        }
    }
}
