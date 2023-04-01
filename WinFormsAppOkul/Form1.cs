namespace WinFormsAppOkul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonHesapla_Click(object sender, EventArgs e)
        {
            /* De�i�kenleri tan�mlad�k
             * (Girenler,��kanlar)*/
            string ad;
            int sinav1, sinav2;
            double ortalama;

            //De�i�kenlere de�er aktard�k
            ad = textBoxAd.Text;
            sinav1 = Convert.ToInt32(textBoxSinav1.Text);
            sinav2 = Convert.ToInt32(textBoxSinav2.Text);

            //Hesaplamalar� yapt�k
            ortalama = (sinav1 + sinav2) / 2;

            //�art kontrol� yapt�k
            if (ortalama >= 45)
            {
                //Sonucu yazd�rd�k
                labelSonuc.Text = "Say�n " + ad + "Ortalaman�z: " + ortalama + " GE�T�";
            }
            else
            {
                //Sonucu yazd�rd�k
                labelSonuc.Text = "Say�n " + ad + "Ortalaman�z: " + ortalama + " KALDI";
            }
        }

        private void linkLabelYas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormYas formYas = new FormYas();
            formYas.Show();
            this.Hide();        
        }
    }
}