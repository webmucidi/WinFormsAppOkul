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
            /* Deðiþkenleri tanýmladýk
             * (Girenler,Çýkanlar)*/
            string ad;
            int sinav1, sinav2;
            double ortalama;

            //Deðiþkenlere deðer aktardýk
            ad = textBoxAd.Text;
            sinav1 = Convert.ToInt32(textBoxSinav1.Text);
            sinav2 = Convert.ToInt32(textBoxSinav2.Text);

            //Hesaplamalarý yaptýk
            ortalama = (sinav1 + sinav2) / 2;

            //Þart kontrolü yaptýk
            if (ortalama >= 45)
            {
                //Sonucu yazdýrdýk
                labelSonuc.Text = "Sayýn " + ad + "Ortalamanýz: " + ortalama + " GEÇTÝ";
            }
            else
            {
                //Sonucu yazdýrdýk
                labelSonuc.Text = "Sayýn " + ad + "Ortalamanýz: " + ortalama + " KALDI";
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