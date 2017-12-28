using System;
using System.Collections.Generic;

namespace SimCorp.IMS.SMSReceiverWFA {
    public class Format {
         /*ublic static string FormatWithTime(string message) {
              return $"[{DateTime.Now}] {message}";
          }*/

        public delegate string FormatDelegate(string text);

      //public readonly FormatDelegate Formatter = new FormatDelegate(FormatWithTime);

        public string OnSMSReceived(string message, FormatDelegate del) {
            return del(message);
        }

        public Dictionary<int, FormatDelegate> FormatType = new Dictionary<int, FormatDelegate>();

        public Format() {
            FormatType.Add(0, (message) => $"{message}");
            FormatType.Add(1, (message) => $"[{DateTime.Now}] {message}");
            FormatType.Add(2, (message) => $"{message} [{DateTime.Now}]");
            FormatType.Add(3, (message) => $"{message} Tin-din");
            FormatType.Add(4, (message) => $"{message.ToLower()}");
            FormatType.Add(5, (message) => $"{message.ToUpper()}");

        }
    }   
}
