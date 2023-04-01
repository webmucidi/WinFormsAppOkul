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
    public partial class FormYas : Form
    {
        public FormYas()
        {
            InitializeComponent();
        }

        private void buttonKontrol_Click(object sender, EventArgs e)
        {
            int yas;
            string ad;

            yas = Convert.ToInt32(textBoxYas.Text);
            ad = textBoxAd.Text;

            if (yas < 18)
            {
                MessageBox.Show("Sevgili " + ad + "Ehliyet alamazsınız!");
            }
            else
            {
                if (yas >= 18 && yas <= 35)
                {
                    MessageBox.Show("Sevgili " + ad + "Ehliyet alabilirsiniz.!");

                }
                else
                {
                    MessageBox.Show("Sevgili " + ad + "Ehliyet alıpta ne yapacaksın bu yaştan sonra!");

                }
            }


        }

        private void linkLabelDonguOrnek_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormDongu formDongu = new FormDongu();
            formDongu.Show();
            this.Hide();

        }
    }
}
