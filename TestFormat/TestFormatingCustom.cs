using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimCorp.IMS.SMSReceiverWFA;
using System;
using static SimCorp.IMS.SMSReceiverWFA.Format;

namespace SimCorp.IMS.TestFormat {
    [TestClass]
    public class TestFormatingCustom {
        [TestMethod]
        public void TestFormating3() {
            // Arrange
            Format format = new Format();
            FormatDelegate currentFormat;
            currentFormat = format.FormatType[3];

            //Act
            string unformatedText = "New message";

            //Assert
            Assert.IsTrue(format.OnSMSReceived(unformatedText, currentFormat).ToLower().Contains(unformatedText.ToLower()));
        }
    }
}
