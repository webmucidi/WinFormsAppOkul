namespace WinFormsAppOkul
{
    partial class FormDongu
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
            label1 = new Label();
            checkedListBoxKahveler = new CheckedListBox();
            label2 = new Label();
            listBoxSecimler = new ListBox();
            buttonOde = new Button();
            labelSonuc = new Label();
            buttonTemizle = new Button();
            radioButtonTall = new RadioButton();
            radioButtonGrande = new RadioButton();
            radioButtonVenti = new RadioButton();
            buttonTumunuSec = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 112);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Kahve seçiminiz:";
            // 
            // checkedListBoxKahveler
            // 
            checkedListBoxKahveler.CheckOnClick = true;
            checkedListBoxKahveler.FormattingEnabled = true;
            checkedListBoxKahveler.Location = new Point(234, 77);
            checkedListBoxKahveler.Name = "checkedListBoxKahveler";
            checkedListBoxKahveler.Size = new Size(120, 94);
            checkedListBoxKahveler.TabIndex = 1;
            checkedListBoxKahveler.SelectedIndexChanged += checkedListBoxKahveler_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(393, 112);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 2;
            label2.Text = "Boyut seçiminiz:";
            // 
            // listBoxSecimler
            // 
            listBoxSecimler.FormattingEnabled = true;
            listBoxSecimler.ItemHeight = 15;
            listBoxSecimler.Location = new Point(507, 250);
            listBoxSecimler.Name = "listBoxSecimler";
            listBoxSecimler.Size = new Size(120, 94);
            listBoxSecimler.TabIndex = 3;
            // 
            // buttonOde
            // 
            buttonOde.Location = new Point(230, 234);
            buttonOde.Name = "buttonOde";
            buttonOde.Size = new Size(124, 71);
            buttonOde.TabIndex = 4;
            buttonOde.Text = "Ödeme sayfasına git";
            buttonOde.UseVisualStyleBackColor = true;
            // 
            // labelSonuc
            // 
            labelSonuc.AutoSize = true;
            labelSonuc.Location = new Point(414, 251);
            labelSonuc.Name = "labelSonuc";
            labelSonuc.Size = new Size(73, 15);
            labelSonuc.TabIndex = 5;
            labelSonuc.Text = "Seçimleriniz:";
            // 
            // buttonTemizle
            // 
            buttonTemizle.Location = new Point(228, 321);
            buttonTemizle.Name = "buttonTemizle";
            buttonTemizle.Size = new Size(126, 23);
            buttonTemizle.TabIndex = 6;
            buttonTemizle.Text = "Seçimleri Sil";
            buttonTemizle.UseVisualStyleBackColor = true;
            buttonTemizle.Click += buttonTemizle_Click;
            // 
            // radioButtonTall
            // 
            radioButtonTall.AutoSize = true;
            radioButtonTall.Location = new Point(503, 108);
            radioButtonTall.Name = "radioButtonTall";
            radioButtonTall.Size = new Size(42, 19);
            radioButtonTall.TabIndex = 7;
            radioButtonTall.TabStop = true;
            radioButtonTall.Text = "Tall";
            radioButtonTall.UseVisualStyleBackColor = true;
            // 
            // radioButtonGrande
            // 
            radioButtonGrande.AutoSize = true;
            radioButtonGrande.Location = new Point(563, 109);
            radioButtonGrande.Name = "radioButtonGrande";
            radioButtonGrande.Size = new Size(63, 19);
            radioButtonGrande.TabIndex = 8;
            radioButtonGrande.TabStop = true;
            radioButtonGrande.Text = "Grande";
            radioButtonGrande.UseVisualStyleBackColor = true;
            // 
            // radioButtonVenti
            // 
            radioButtonVenti.AutoSize = true;
            radioButtonVenti.Location = new Point(632, 108);
            radioButtonVenti.Name = "radioButtonVenti";
            radioButtonVenti.Size = new Size(51, 19);
            radioButtonVenti.TabIndex = 9;
            radioButtonVenti.TabStop = true;
            radioButtonVenti.Text = "Venti";
            radioButtonVenti.UseVisualStyleBackColor = true;
            // 
            // buttonTumunuSec
            // 
            buttonTumunuSec.Location = new Point(230, 193);
            buttonTumunuSec.Name = "buttonTumunuSec";
            buttonTumunuSec.Size = new Size(124, 23);
            buttonTumunuSec.TabIndex = 10;
            buttonTumunuSec.Text = "Tümünü Seç";
            buttonTumunuSec.UseVisualStyleBackColor = true;
            buttonTumunuSec.Click += buttonTumunuSec_Click;
            // 
            // FormDongu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonTumunuSec);
            Controls.Add(radioButtonVenti);
            Controls.Add(radioButtonGrande);
            Controls.Add(radioButtonTall);
            Controls.Add(buttonTemizle);
            Controls.Add(labelSonuc);
            Controls.Add(buttonOde);
            Controls.Add(listBoxSecimler);
            Controls.Add(label2);
            Controls.Add(checkedListBoxKahveler);
            Controls.Add(label1);
            Name = "FormDongu";
            Text = "FormDongu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckedListBox checkedListBoxKahveler;
        private Label label2;
        private ListBox listBoxSecimler;
        private Button buttonOde;
        private Label labelSonuc;
        private Button buttonTemizle;
        private RadioButton radioButtonTall;
        private RadioButton radioButtonGrande;
        private RadioButton radioButtonVenti;
        private Button buttonTumunuSec;
    }
}