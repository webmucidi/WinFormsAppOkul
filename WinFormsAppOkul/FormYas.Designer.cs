namespace WinFormsAppOkul
{
    partial class FormYas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxAd = new TextBox();
            textBoxYas = new TextBox();
            buttonKontrol = new Button();
            label1 = new Label();
            label2 = new Label();
            linkLabelDonguOrnek = new LinkLabel();
            SuspendLayout();
            // 
            // textBoxAd
            // 
            textBoxAd.Location = new Point(155, 89);
            textBoxAd.Name = "textBoxAd";
            textBoxAd.Size = new Size(100, 23);
            textBoxAd.TabIndex = 0;
            // 
            // textBoxYas
            // 
            textBoxYas.Location = new Point(155, 127);
            textBoxYas.Name = "textBoxYas";
            textBoxYas.Size = new Size(100, 23);
            textBoxYas.TabIndex = 1;
            // 
            // buttonKontrol
            // 
            buttonKontrol.Location = new Point(155, 156);
            buttonKontrol.Name = "buttonKontrol";
            buttonKontrol.Size = new Size(100, 23);
            buttonKontrol.TabIndex = 2;
            buttonKontrol.Text = "Ehliyet Kontrol";
            buttonKontrol.UseVisualStyleBackColor = true;
            buttonKontrol.Click += buttonKontrol_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonShadow;
            label1.Location = new Point(71, 97);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 3;
            label1.Text = "Ad-Soyad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveBorder;
            label2.Location = new Point(71, 135);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 4;
            label2.Text = "Yaşınız:";
            // 
            // linkLabelDonguOrnek
            // 
            linkLabelDonguOrnek.AutoSize = true;
            linkLabelDonguOrnek.Location = new Point(155, 202);
            linkLabelDonguOrnek.Name = "linkLabelDonguOrnek";
            linkLabelDonguOrnek.Size = new Size(196, 15);
            linkLabelDonguOrnek.TabIndex = 5;
            linkLabelDonguOrnek.TabStop = true;
            linkLabelDonguOrnek.Text = "Döngü örneğine gitmek için tıklayın";
            linkLabelDonguOrnek.LinkClicked += linkLabelDonguOrnek_LinkClicked;
            // 
            // FormYas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabelDonguOrnek);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonKontrol);
            Controls.Add(textBoxYas);
            Controls.Add(textBoxAd);
            Name = "FormYas";
            Text = "FormYas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxAd;
        private TextBox textBoxYas;
        private Button buttonKontrol;
        private Label label1;
        private Label label2;
        private LinkLabel linkLabelDonguOrnek;
    }
}