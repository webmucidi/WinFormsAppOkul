namespace WinFormsAppOkul
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBoxAd = new TextBox();
            label2 = new Label();
            textBoxSinav1 = new TextBox();
            label3 = new Label();
            textBoxSinav2 = new TextBox();
            buttonHesapla = new Button();
            labelSonuc = new Label();
            linkLabelYas = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 50);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 0;
            label1.Text = "Ad-Soyad giriniz:";
            // 
            // textBoxAd
            // 
            textBoxAd.Location = new Point(229, 42);
            textBoxAd.Name = "textBoxAd";
            textBoxAd.Size = new Size(230, 23);
            textBoxAd.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 104);
            label2.Name = "label2";
            label2.Size = new Size(123, 15);
            label2.TabIndex = 2;
            label2.Text = "1.sınav notunu giriniz:";
            // 
            // textBoxSinav1
            // 
            textBoxSinav1.Location = new Point(229, 96);
            textBoxSinav1.Name = "textBoxSinav1";
            textBoxSinav1.Size = new Size(100, 23);
            textBoxSinav1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 160);
            label3.Name = "label3";
            label3.Size = new Size(123, 15);
            label3.TabIndex = 4;
            label3.Text = "2.sınav notunu giriniz:";
            // 
            // textBoxSinav2
            // 
            textBoxSinav2.Location = new Point(229, 152);
            textBoxSinav2.Name = "textBoxSinav2";
            textBoxSinav2.Size = new Size(100, 23);
            textBoxSinav2.TabIndex = 5;
            // 
            // buttonHesapla
            // 
            buttonHesapla.Location = new Point(229, 211);
            buttonHesapla.Name = "buttonHesapla";
            buttonHesapla.Size = new Size(230, 23);
            buttonHesapla.TabIndex = 6;
            buttonHesapla.Text = "ORTALAMAYI HESAPLA";
            buttonHesapla.UseVisualStyleBackColor = true;
            buttonHesapla.Click += buttonHesapla_Click;
            // 
            // labelSonuc
            // 
            labelSonuc.AutoSize = true;
            labelSonuc.Location = new Point(229, 273);
            labelSonuc.Name = "labelSonuc";
            labelSonuc.Size = new Size(0, 15);
            labelSonuc.TabIndex = 7;
            // 
            // linkLabelYas
            // 
            linkLabelYas.AutoSize = true;
            linkLabelYas.Location = new Point(229, 271);
            linkLabelYas.Name = "linkLabelYas";
            linkLabelYas.Size = new Size(218, 15);
            linkLabelYas.TabIndex = 8;
            linkLabelYas.TabStop = true;
            linkLabelYas.Text = "Yaş kontrol örneğine gitmek için tıklayın";
            linkLabelYas.LinkClicked += linkLabelYas_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabelYas);
            Controls.Add(labelSonuc);
            Controls.Add(buttonHesapla);
            Controls.Add(textBoxSinav2);
            Controls.Add(label3);
            Controls.Add(textBoxSinav1);
            Controls.Add(label2);
            Controls.Add(textBoxAd);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxAd;
        private Label label2;
        private TextBox textBoxSinav1;
        private Label label3;
        private TextBox textBoxSinav2;
        private Button buttonHesapla;
        private Label labelSonuc;
        private LinkLabel linkLabelYas;
    }
}