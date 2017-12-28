using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.SMSReceiverWFA;
using System;
using static SimCorp.IMS.SMSReceiverWFA.Format;

namespace SimCorp.IMS.TestFormat {
    [TestClass]
    public class TestFormatingStartWithDate {
        [TestMethod]
        public void TestFormating1() {
            // Arrange
            Format format = new Format();
            FormatDelegate currentFormat;
            currentFormat = format.FormatType[1];

            //Act
            string unformatedText = "New message";
            string expectedString = $"[{DateTime.Now}] {unformatedText}";
            format.OnSMSReceived(unformatedText, currentFormat);

            //Assert
            Assert.AreEqual(expectedString, format.OnSMSReceived(unformatedText, currentFormat));
        }
    }
}
