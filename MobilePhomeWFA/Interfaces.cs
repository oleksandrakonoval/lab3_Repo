using System;
using System.Windows.Forms;
using SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents.Headset;
using SimCorp.IMS.MobilePhoneLibrary.MobilePhone;
using SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents.Charger;
using SimCorp.IMS.MobilePhoneLibrary.MobilePhoneComponents.Simcard;
using SimCorp.IMS.MobilePhoneLibrary.General;

namespace SimCorp.IMS.MobilePhomeWFA
{
    public partial class InterfacesForm : Form
    {
        SimCorpMobile MyMobile;
      
        private IOutput output;

        public InterfacesForm()
        {
            InitializeComponent();
            MyMobile = new SimCorpMobile();

            Invoke(new Action(() => { }));
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            output = new WFAOutput(textBox1);

            if (checkedListBox1.SelectedIndices.Count==1) {
                MyMobile.PlaybackComponent = HeadsetFactory.GetPlayback((headsetTypik)checkedListBox1.SelectedIndex, output);
                MyMobile.PlaybackComponent.Play(textBox1);
            }

            if (checkedListBox2.SelectedIndices.Count == 1) {
                MyMobile.SimCardItem = SimCardFactory.GetSimCard((SimCardTypeik)checkedListBox2.SelectedIndex, output);
                MyMobile.SimCardItem.Call(textBox1);
            }

            if (checkedListBox3.SelectedIndices.Count == 1) {
                MyMobile.ChargerComponenet = ChargerFactory.GetCharger((ChargerTypik)checkedListBox3.SelectedIndex, output);
                MyMobile.ChargerComponenet.Charge(textBox1);
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && checkedListBox1.CheckedItems.Count > 0)
            {
                checkedListBox1.ItemCheck -= checkedListBox1_ItemCheck;
                checkedListBox1.SetItemChecked(checkedListBox1.CheckedIndices[0], false);
                checkedListBox1.ItemCheck += checkedListBox1_ItemCheck;
            }
        }

        private void checkedListBox2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && checkedListBox2.CheckedItems.Count > 0)
            {
                checkedListBox2.ItemCheck -= checkedListBox2_ItemCheck;
                checkedListBox2.SetItemChecked(checkedListBox2.CheckedIndices[0], false);
                checkedListBox2.ItemCheck += checkedListBox2_ItemCheck;
            }
        }

        private void checkedListBox3_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked && checkedListBox3.CheckedItems.Count > 0)
            {
                checkedListBox3.ItemCheck -= checkedListBox3_ItemCheck;
                checkedListBox3.SetItemChecked(checkedListBox3.CheckedIndices[0], false);
                checkedListBox3.ItemCheck += checkedListBox3_ItemCheck;
            }
        }
    }
}
