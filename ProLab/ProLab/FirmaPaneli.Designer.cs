namespace ProLab
{
    partial class Arac
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
            components = new System.ComponentModel.Container();
            AraclariGoruntule = new ListBox();
            label1 = new Label();
            textIdekle = new TextBox();
            textyolcusayisi = new TextBox();
            label4 = new Label();
            textyakit = new TextBox();
            label2 = new Label();
            textsilId = new TextBox();
            label3 = new Label();
            butonaracekle = new Button();
            buttonaracsil = new Button();
            SeferleriGoruntule = new ListBox();
            label5 = new Label();
            textnereden = new TextBox();
            textnereye = new TextBox();
            label6 = new Label();
            bindingSource1 = new BindingSource(components);
            textseferekle = new TextBox();
            label7 = new Label();
            label8 = new Label();
            textulasimekle = new TextBox();
            dateTimeekle = new DateTimePicker();
            ekleseferbuton = new Button();
            label9 = new Label();
            textsefernoSil = new TextBox();
            silseferbuton = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // AraclariGoruntule
            // 
            AraclariGoruntule.FormattingEnabled = true;
            AraclariGoruntule.ItemHeight = 20;
            AraclariGoruntule.Location = new Point(15, 7);
            AraclariGoruntule.Name = "AraclariGoruntule";
            AraclariGoruntule.Size = new Size(434, 424);
            AraclariGoruntule.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(455, 30);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 1;
            label1.Text = "Araç ID";
            // 
            // textIdekle
            // 
            textIdekle.Location = new Point(546, 27);
            textIdekle.Name = "textIdekle";
            textIdekle.Size = new Size(125, 27);
            textIdekle.TabIndex = 2;
            // 
            // textyolcusayisi
            // 
            textyolcusayisi.Location = new Point(546, 88);
            textyolcusayisi.Name = "textyolcusayisi";
            textyolcusayisi.Size = new Size(125, 27);
            textyolcusayisi.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(455, 89);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 7;
            label4.Text = "Yolcu Sayısı";
            // 
            // textyakit
            // 
            textyakit.Location = new Point(546, 59);
            textyakit.Name = "textyakit";
            textyakit.Size = new Size(125, 27);
            textyakit.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(455, 62);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 9;
            label2.Text = "Yakıt Türü";
            // 
            // textsilId
            // 
            textsilId.Location = new Point(519, 232);
            textsilId.Name = "textsilId";
            textsilId.Size = new Size(125, 27);
            textsilId.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(455, 232);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 11;
            label3.Text = "Arac ID";
            // 
            // butonaracekle
            // 
            butonaracekle.Location = new Point(455, 152);
            butonaracekle.Name = "butonaracekle";
            butonaracekle.Size = new Size(94, 29);
            butonaracekle.TabIndex = 13;
            butonaracekle.Text = "Ekle";
            butonaracekle.UseVisualStyleBackColor = true;
            butonaracekle.Click += butonaracekle_Click;
            // 
            // buttonaracsil
            // 
            buttonaracsil.Location = new Point(519, 285);
            buttonaracsil.Name = "buttonaracsil";
            buttonaracsil.Size = new Size(94, 29);
            buttonaracsil.TabIndex = 14;
            buttonaracsil.Text = "Sil";
            buttonaracsil.UseVisualStyleBackColor = true;
            buttonaracsil.Click += buttonaracsil_Click;
            // 
            // SeferleriGoruntule
            // 
            SeferleriGoruntule.FormattingEnabled = true;
            SeferleriGoruntule.ItemHeight = 20;
            SeferleriGoruntule.Location = new Point(1014, 14);
            SeferleriGoruntule.Name = "SeferleriGoruntule";
            SeferleriGoruntule.Size = new Size(454, 424);
            SeferleriGoruntule.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(750, 27);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 16;
            label5.Text = "Nereden";
            // 
            // textnereden
            // 
            textnereden.Location = new Point(835, 24);
            textnereden.Name = "textnereden";
            textnereden.Size = new Size(125, 27);
            textnereden.TabIndex = 17;
            // 
            // textnereye
            // 
            textnereye.Location = new Point(835, 66);
            textnereye.Name = "textnereye";
            textnereye.Size = new Size(125, 27);
            textnereye.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(750, 69);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 18;
            label6.Text = "Nereye";
            // 
            // textseferekle
            // 
            textseferekle.Location = new Point(835, 126);
            textseferekle.Name = "textseferekle";
            textseferekle.Size = new Size(125, 27);
            textseferekle.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(750, 133);
            label7.Name = "label7";
            label7.Size = new Size(63, 20);
            label7.TabIndex = 20;
            label7.Text = "SeferNo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(750, 190);
            label8.Name = "label8";
            label8.Size = new Size(87, 20);
            label8.TabIndex = 22;
            label8.Text = "Ulaşım Türü";
            // 
            // textulasimekle
            // 
            textulasimekle.Location = new Point(835, 183);
            textulasimekle.Name = "textulasimekle";
            textulasimekle.Size = new Size(125, 27);
            textulasimekle.TabIndex = 23;
            // 
            // dateTimeekle
            // 
            dateTimeekle.Location = new Point(750, 230);
            dateTimeekle.Name = "dateTimeekle";
            dateTimeekle.Size = new Size(250, 27);
            dateTimeekle.TabIndex = 24;
            // 
            // ekleseferbuton
            // 
            ekleseferbuton.Location = new Point(815, 276);
            ekleseferbuton.Name = "ekleseferbuton";
            ekleseferbuton.Size = new Size(94, 29);
            ekleseferbuton.TabIndex = 25;
            ekleseferbuton.Text = "Ekle";
            ekleseferbuton.UseVisualStyleBackColor = true;
            ekleseferbuton.Click += ekleseferbuton_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(750, 323);
            label9.Name = "label9";
            label9.Size = new Size(67, 20);
            label9.TabIndex = 26;
            label9.Text = "Sefer No";
            // 
            // textsefernoSil
            // 
            textsefernoSil.Location = new Point(835, 320);
            textsefernoSil.Name = "textsefernoSil";
            textsefernoSil.Size = new Size(125, 27);
            textsefernoSil.TabIndex = 27;
            // 
            // silseferbuton
            // 
            silseferbuton.Location = new Point(815, 382);
            silseferbuton.Name = "silseferbuton";
            silseferbuton.Size = new Size(94, 29);
            silseferbuton.TabIndex = 28;
            silseferbuton.Text = "Sil";
            silseferbuton.UseVisualStyleBackColor = true;
            silseferbuton.Click += silseferbuton_Click;
            // 
            // Arac
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1480, 450);
            Controls.Add(silseferbuton);
            Controls.Add(textsefernoSil);
            Controls.Add(label9);
            Controls.Add(ekleseferbuton);
            Controls.Add(dateTimeekle);
            Controls.Add(textulasimekle);
            Controls.Add(label8);
            Controls.Add(textseferekle);
            Controls.Add(label7);
            Controls.Add(textnereye);
            Controls.Add(label6);
            Controls.Add(textnereden);
            Controls.Add(label5);
            Controls.Add(SeferleriGoruntule);
            Controls.Add(buttonaracsil);
            Controls.Add(butonaracekle);
            Controls.Add(textsilId);
            Controls.Add(label3);
            Controls.Add(textyakit);
            Controls.Add(label2);
            Controls.Add(textyolcusayisi);
            Controls.Add(label4);
            Controls.Add(textIdekle);
            Controls.Add(label1);
            Controls.Add(AraclariGoruntule);
            Name = "Arac";
            Text = "FirmaPaneli";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox AraclariGoruntule;
        private Label label1;
        private TextBox textIdekle;
        private TextBox textyolcusayisi;
        private Label label4;
        private TextBox textyakit;
        private Label label2;
        private TextBox textsilId;
        private Label label3;
        private Button butonaracekle;
        private Button buttonaracsil;
        private ListBox SeferleriGoruntule;
        private Label label5;
        private TextBox textnereden;
        private TextBox textnereye;
        private Label label6;
        private BindingSource bindingSource1;
        private TextBox textseferekle;
        private Label label7;
        private Label label8;
        private TextBox textulasimekle;
        private DateTimePicker dateTimeekle;
        private Button ekleseferbuton;
        private Label label9;
        private TextBox textsefernoSil;
        private Button silseferbuton;
    }
}