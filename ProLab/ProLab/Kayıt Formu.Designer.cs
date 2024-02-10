namespace ProLab
{
    partial class Kayıt_Formu
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            radioButtonKadın = new RadioButton();
            radioButtonErkek = new RadioButton();
            buttonTamam = new Button();
            buttonIptal = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 54);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(122, 52);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(122, 88);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(110, 23);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 94);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 2;
            label2.Text = "SoyAd";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(122, 170);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(110, 23);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 136);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 4;
            label3.Text = "T.C.";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(122, 130);
            maskedTextBox1.Margin = new Padding(3, 2, 3, 2);
            maskedTextBox1.Mask = "_________";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(57, 23);
            maskedTextBox1.TabIndex = 6;
            // 
            // radioButtonKadın
            // 
            radioButtonKadın.AutoSize = true;
            radioButtonKadın.Checked = true;
            radioButtonKadın.Location = new Point(35, 208);
            radioButtonKadın.Margin = new Padding(3, 2, 3, 2);
            radioButtonKadın.Name = "radioButtonKadın";
            radioButtonKadın.Size = new Size(55, 19);
            radioButtonKadın.TabIndex = 7;
            radioButtonKadın.TabStop = true;
            radioButtonKadın.Text = "Kadın";
            radioButtonKadın.UseVisualStyleBackColor = true;
            radioButtonKadın.CheckedChanged += radioButtonKadın_CheckedChanged;
            // 
            // radioButtonErkek
            // 
            radioButtonErkek.AutoSize = true;
            radioButtonErkek.Location = new Point(175, 208);
            radioButtonErkek.Margin = new Padding(3, 2, 3, 2);
            radioButtonErkek.Name = "radioButtonErkek";
            radioButtonErkek.Size = new Size(53, 19);
            radioButtonErkek.TabIndex = 8;
            radioButtonErkek.Text = "Erkek";
            radioButtonErkek.UseVisualStyleBackColor = true;
            radioButtonErkek.CheckedChanged += radioButtonErkek_CheckedChanged;
            // 
            // buttonTamam
            // 
            buttonTamam.Location = new Point(173, 241);
            buttonTamam.Margin = new Padding(3, 2, 3, 2);
            buttonTamam.Name = "buttonTamam";
            buttonTamam.Size = new Size(82, 22);
            buttonTamam.TabIndex = 9;
            buttonTamam.Text = "Tamam";
            buttonTamam.UseVisualStyleBackColor = true;
            buttonTamam.Click += buttonTamam_Click;
            // 
            // buttonIptal
            // 
            buttonIptal.Location = new Point(32, 241);
            buttonIptal.Margin = new Padding(3, 2, 3, 2);
            buttonIptal.Name = "buttonIptal";
            buttonIptal.Size = new Size(82, 22);
            buttonIptal.TabIndex = 10;
            buttonIptal.Text = "İptal";
            buttonIptal.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 175);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 11;
            label4.Text = "Doğum Tarihi";
            // 
            // Kayıt_Formu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 338);
            Controls.Add(label4);
            Controls.Add(buttonIptal);
            Controls.Add(buttonTamam);
            Controls.Add(radioButtonErkek);
            Controls.Add(radioButtonKadın);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Kayıt_Formu";
            Text = "Kayıt_Formu";
            Load += Kayıt_Formu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private MaskedTextBox maskedTextBox1;
        private RadioButton radioButtonKadın;
        private RadioButton radioButtonErkek;
        private Button buttonTamam;
        private Button buttonIptal;
        private Label label4;
    }
}