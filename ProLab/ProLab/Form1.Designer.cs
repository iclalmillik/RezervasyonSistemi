namespace ProLab
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
            kullanıcıPanelabel = new Label();
            adminPanelabel = new Label();
            firmaPanelabel = new Label();
            adminKullanıcıAdıLabel = new Label();
            adminSifreLabel = new Label();
            adminKullanıcıAdıText = new TextBox();
            adminSifreText = new TextBox();
            adminPaneliGirisBtn = new Button();
            firmaKullaniciAdiText = new TextBox();
            firmaSifreText = new TextBox();
            firmaGirisYap = new Button();
            butonBiletAl = new Button();
            SuspendLayout();
            // 
            // kullanıcıPanelabel
            // 
            kullanıcıPanelabel.AutoSize = true;
            kullanıcıPanelabel.Location = new Point(114, 31);
            kullanıcıPanelabel.Name = "kullanıcıPanelabel";
            kullanıcıPanelabel.Size = new Size(104, 20);
            kullanıcıPanelabel.TabIndex = 0;
            kullanıcıPanelabel.Text = "KullanıcıPaneli";
            // 
            // adminPanelabel
            // 
            adminPanelabel.AutoSize = true;
            adminPanelabel.Location = new Point(668, 31);
            adminPanelabel.Name = "adminPanelabel";
            adminPanelabel.Size = new Size(96, 20);
            adminPanelabel.TabIndex = 1;
            adminPanelabel.Text = "Admin Paneli";
            // 
            // firmaPanelabel
            // 
            firmaPanelabel.AutoSize = true;
            firmaPanelabel.Location = new Point(1223, 31);
            firmaPanelabel.Name = "firmaPanelabel";
            firmaPanelabel.Size = new Size(89, 20);
            firmaPanelabel.TabIndex = 2;
            firmaPanelabel.Text = "Firma Paneli";
            // 
            // adminKullanıcıAdıLabel
            // 
            adminKullanıcıAdıLabel.AutoSize = true;
            adminKullanıcıAdıLabel.Location = new Point(576, 117);
            adminKullanıcıAdıLabel.Name = "adminKullanıcıAdıLabel";
            adminKullanıcıAdıLabel.Size = new Size(92, 20);
            adminKullanıcıAdıLabel.TabIndex = 3;
            adminKullanıcıAdıLabel.Text = "Kullanıcı Adı";
            // 
            // adminSifreLabel
            // 
            adminSifreLabel.AutoSize = true;
            adminSifreLabel.Location = new Point(603, 242);
            adminSifreLabel.Name = "adminSifreLabel";
            adminSifreLabel.Size = new Size(39, 20);
            adminSifreLabel.TabIndex = 4;
            adminSifreLabel.Text = "Şifre";
            // 
            // adminKullanıcıAdıText
            // 
            adminKullanıcıAdıText.Location = new Point(768, 110);
            adminKullanıcıAdıText.Name = "adminKullanıcıAdıText";
            adminKullanıcıAdıText.Size = new Size(125, 27);
            adminKullanıcıAdıText.TabIndex = 5;
            adminKullanıcıAdıText.TextChanged += adminKullanıcıAdıText_TextChanged;
            // 
            // adminSifreText
            // 
            adminSifreText.Location = new Point(768, 235);
            adminSifreText.Name = "adminSifreText";
            adminSifreText.Size = new Size(125, 27);
            adminSifreText.TabIndex = 6;
            // 
            // adminPaneliGirisBtn
            // 
            adminPaneliGirisBtn.Location = new Point(670, 369);
            adminPaneliGirisBtn.Name = "adminPaneliGirisBtn";
            adminPaneliGirisBtn.Size = new Size(94, 29);
            adminPaneliGirisBtn.TabIndex = 7;
            adminPaneliGirisBtn.Text = "Giriş Yap";
            adminPaneliGirisBtn.UseVisualStyleBackColor = true;
            adminPaneliGirisBtn.Click += adminPaneliGirisBtn_Click;
            // 
            // firmaKullaniciAdiText
            // 
            firmaKullaniciAdiText.Location = new Point(1210, 114);
            firmaKullaniciAdiText.Name = "firmaKullaniciAdiText";
            firmaKullaniciAdiText.Size = new Size(125, 27);
            firmaKullaniciAdiText.TabIndex = 8;
            // 
            // firmaSifreText
            // 
            firmaSifreText.Location = new Point(1210, 235);
            firmaSifreText.Name = "firmaSifreText";
            firmaSifreText.Size = new Size(125, 27);
            firmaSifreText.TabIndex = 9;
            // 
            // firmaGirisYap
            // 
            firmaGirisYap.Location = new Point(1218, 349);
            firmaGirisYap.Name = "firmaGirisYap";
            firmaGirisYap.Size = new Size(94, 29);
            firmaGirisYap.TabIndex = 10;
            firmaGirisYap.Text = "Giriş Yap";
            firmaGirisYap.UseVisualStyleBackColor = true;
            firmaGirisYap.Click += firmaGirisYap_Click;
            // 
            // butonBiletAl
            // 
            butonBiletAl.Location = new Point(114, 117);
            butonBiletAl.Name = "butonBiletAl";
            butonBiletAl.Size = new Size(94, 55);
            butonBiletAl.TabIndex = 11;
            butonBiletAl.Text = "Bilet Al";
            butonBiletAl.UseVisualStyleBackColor = true;
            butonBiletAl.Click += butonBiletAl_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1604, 664);
            Controls.Add(butonBiletAl);
            Controls.Add(firmaGirisYap);
            Controls.Add(firmaSifreText);
            Controls.Add(firmaKullaniciAdiText);
            Controls.Add(adminPaneliGirisBtn);
            Controls.Add(adminSifreText);
            Controls.Add(adminKullanıcıAdıText);
            Controls.Add(adminSifreLabel);
            Controls.Add(adminKullanıcıAdıLabel);
            Controls.Add(firmaPanelabel);
            Controls.Add(adminPanelabel);
            Controls.Add(kullanıcıPanelabel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label kullanıcıPanelabel;
        private Label adminPanelabel;
        private Label firmaPanelabel;
        private Label adminKullanıcıAdıLabel;
        private Label adminSifreLabel;
        private TextBox adminKullanıcıAdıText;
        private TextBox adminSifreText;
        private Button adminPaneliGirisBtn;
        private TextBox firmaKullaniciAdiText;
        private TextBox firmaSifreText;
        private Button firmaGirisYap;
        private Button butonBiletAl;
    }
}