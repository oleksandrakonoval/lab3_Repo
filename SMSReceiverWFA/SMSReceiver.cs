using SimCorp.IMS.MobilePhoneLibrary.General;
using SimCorp.IMS.MobilePhoneLibrary.MobilePhone;
using System;
using System.Windows.Forms;
using static SimCorp.IMS.SMSReceiverWFA.Format;

namespace SimCorp.IMS.SMSReceiverWFA {

    public partial class SMSReceiverForm : Form {

        static Timer timer;
        IOutput output;
        SimCorpMobile MyMobile;
        Format Format = new Format();

        public SMSReceiverForm() {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            
            MyMobile = new SimCorpMobile();
            output = new WFAOutputRichTextBox(richTextBox1);
            MyMobile.SMSProvider = new SMSProvider();                       
            MyMobile.SMSProvider.SMSReceived += (message) => output.WriteLine(message);
        }

        private void SMSReceiverForm_Load(object sender, System.EventArgs e) {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1500;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e) {

            string text = "New SMS received";            
            FormatDelegate currentFormat;
            currentFormat = Format.FormatType[comboBox1.SelectedIndex];

            MyMobile.SMSProvider.ReceiveSMS(Format.OnSMSReceived(text, currentFormat));
        }

    }
}
