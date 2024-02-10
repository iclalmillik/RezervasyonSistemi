namespace ProLab
{
    partial class AdminPaneli
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
            firmaEkleBtn = new Button();
            firmaSilBtn = new Button();
            FirmalariGoruntule = new ListBox();
            label1 = new Label();
            firmaEkleText = new TextBox();
            firmaSilText = new TextBox();
            label2 = new Label();
            label3 = new Label();
            texthizmetbedeli = new TextBox();
            hizmetbedelibuton = new Button();
            SuspendLayout();
            // 
            // firmaEkleBtn
            // 
            firmaEkleBtn.Location = new Point(543, 208);
            firmaEkleBtn.Name = "firmaEkleBtn";
            firmaEkleBtn.Size = new Size(69, 60);
            firmaEkleBtn.TabIndex = 0;
            firmaEkleBtn.Text = "Ekle";
            firmaEkleBtn.UseVisualStyleBackColor = true;
            firmaEkleBtn.Click += firmaEkleBtn_Click;
            // 
            // firmaSilBtn
            // 
            firmaSilBtn.Location = new Point(884, 208);
            firmaSilBtn.Name = "firmaSilBtn";
            firmaSilBtn.Size = new Size(56, 52);
            firmaSilBtn.TabIndex = 2;
            firmaSilBtn.Text = "Sil";
            firmaSilBtn.UseVisualStyleBackColor = true;
            firmaSilBtn.Click += firmaSilBtn_Click;
            // 
            // FirmalariGoruntule
            // 
            FirmalariGoruntule.FormattingEnabled = true;
            FirmalariGoruntule.ItemHeight = 20;
            FirmalariGoruntule.Location = new Point(12, 12);
            FirmalariGoruntule.Name = "FirmalariGoruntule";
            FirmalariGoruntule.Size = new Size(397, 424);
            FirmalariGoruntule.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(535, 42);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 4;
            label1.Text = "Firma Ekle";
            // 
            // firmaEkleText
            // 
            firmaEkleText.Location = new Point(518, 119);
            firmaEkleText.Name = "firmaEkleText";
            firmaEkleText.Size = new Size(125, 27);
            firmaEkleText.TabIndex = 5;
            // 
            // firmaSilText
            // 
            firmaSilText.Location = new Point(842, 119);
            firmaSilText.Name = "firmaSilText";
            firmaSilText.Size = new Size(125, 27);
            firmaSilText.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(874, 42);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 7;
            label2.Text = "Firma Sil";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1187, 42);
            label3.Name = "label3";
            label3.Size = new Size(149, 20);
            label3.TabIndex = 8;
            label3.Text = "Hizmet Bedeli Belirle";
            // 
            // texthizmetbedeli
            // 
            texthizmetbedeli.Location = new Point(1204, 119);
            texthizmetbedeli.Name = "texthizmetbedeli";
            texthizmetbedeli.Size = new Size(125, 27);
            texthizmetbedeli.TabIndex = 9;
            // 
            // hizmetbedelibuton
            // 
            hizmetbedelibuton.Location = new Point(1224, 208);
            hizmetbedelibuton.Name = "hizmetbedelibuton";
            hizmetbedelibuton.Size = new Size(94, 52);
            hizmetbedelibuton.TabIndex = 10;
            hizmetbedelibuton.Text = "Onayla";
            hizmetbedelibuton.UseVisualStyleBackColor = true;
            hizmetbedelibuton.Click += hizmetbedelibuton_Click;
            // 
            // AdminPaneli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1466, 659);
            Controls.Add(hizmetbedelibuton);
            Controls.Add(texthizmetbedeli);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(firmaSilText);
            Controls.Add(firmaEkleText);
            Controls.Add(label1);
            Controls.Add(FirmalariGoruntule);
            Controls.Add(firmaSilBtn);
            Controls.Add(firmaEkleBtn);
            Name = "AdminPaneli";
            Text = "AdminPaneli";
            Load += AdminPaneli_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button firmaEkleBtn;
        private Button firmaSilBtn;
        private ListBox FirmalariGoruntule;
        private Label label1;
        private TextBox firmaEkleText;
        private TextBox firmaSilText;
        private Label label2;
        private Label label3;
        private TextBox texthizmetbedeli;
        private Button hizmetbedelibuton;
    }
}