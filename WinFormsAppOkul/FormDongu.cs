using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppOkul
{
    public partial class FormDongu : Form
    {
        public FormDongu()
        {
            InitializeComponent();
            string[] kahveler = { "Latte", "Americano", "Espresso", "Mocha", "Türk Kahvesi" };
            checkedListBoxKahveler.Items.AddRange(kahveler);
        }
        private void checkedListBoxKahveler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBoxKahveler.GetItemCheckState(checkedListBoxKahveler.SelectedIndex) == CheckState.Checked)
            {
                listBoxSecimler.Items.Add(checkedListBoxKahveler.SelectedItem as string);

            }
            else
            {
                listBoxSecimler.Items.Remove(checkedListBoxKahveler.SelectedItem.ToString());
            }
        }
        private void buttonTumunuSec_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < checkedListBoxKahveler.Items.Count; i++)
            {
                checkedListBoxKahveler.SetItemChecked(i, true);
                listBoxSecimler.Items.Add(checkedListBoxKahveler.Items[i]);
            }
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            listBoxSecimler.Items.Clear();
        }
    }
}
