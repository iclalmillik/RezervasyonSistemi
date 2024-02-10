namespace ProLab
{
    partial class KullaniciPaneli
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
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            label1 = new Label();
            comboOtobus = new ComboBox();
            comboNereden = new ComboBox();
            label2 = new Label();
            comboNereye = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            dateTimeTarih = new DateTimePicker();
            label5 = new Label();
            buttonKaydet = new Button();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtFiyat = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            listView1.GridLines = true;
            listView1.Location = new Point(922, 5);
            listView1.Margin = new Padding(3, 2, 3, 2);
            listView1.Name = "listView1";
            listView1.Size = new Size(532, 388);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Müşteri   ";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "T.C.";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Cinsiyet";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Nereden";
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Nereye";
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Koltuk No";
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Tarih";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Fiyat";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(662, 21);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 1;
            label1.Text = "Otobüz Seçiniz";
            label1.Click += label1_Click;
            // 
            // comboOtobus
            // 
            comboOtobus.FormattingEnabled = true;
            comboOtobus.Items.AddRange(new object[] { "A Firmasi -Otobüs1", "A Firmasi-Otobüs2", "B Firmasi-Otobüs1", "B Firmasi-Otobüs2", "C Firmasi-Otobüs1", "C Firmasi-Ucak1", "C Firmasi-Ucak2", "D Firmasi-Tren1", "D Firmasi-Tren2", "D Firmasi-Tren3", "F Firmasi-Ucak1", "F Firmasi-Ucak2" });
            comboOtobus.Location = new Point(774, 19);
            comboOtobus.Margin = new Padding(3, 2, 3, 2);
            comboOtobus.Name = "comboOtobus";
            comboOtobus.Size = new Size(133, 23);
            comboOtobus.TabIndex = 2;
            comboOtobus.SelectedIndexChanged += comboOtobus_SelectedIndexChanged;
            // 
            // comboNereden
            // 
            comboNereden.FormattingEnabled = true;
            comboNereden.Items.AddRange(new object[] { "İstanbul", "Ankara", "Kocaeli", "Bilecik", "Eskişehir", "Konya" });
            comboNereden.Location = new Point(72, 47);
            comboNereden.Margin = new Padding(3, 2, 3, 2);
            comboNereden.Name = "comboNereden";
            comboNereden.Size = new Size(133, 23);
            comboNereden.TabIndex = 4;
            comboNereden.SelectedIndexChanged += comboNereden_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 45);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 3;
            label2.Text = "Nereden";
            // 
            // comboNereye
            // 
            comboNereye.FormattingEnabled = true;
            comboNereye.Items.AddRange(new object[] { "İstanbul", "Ankara", "Kocaeli", "Bilecik", "Eskişehir", "Konya" });
            comboNereye.Location = new Point(72, 92);
            comboNereye.Margin = new Padding(3, 2, 3, 2);
            comboNereye.Name = "comboNereye";
            comboNereye.Size = new Size(133, 23);
            comboNereye.TabIndex = 6;
            comboNereye.SelectedIndexChanged += comboNereye_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 92);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 5;
            label3.Text = "Nereye";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(625, 219);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 7;
            label4.Text = "Tarih";
            // 
            // dateTimeTarih
            // 
            dateTimeTarih.Format = DateTimePickerFormat.Short;
            dateTimeTarih.Location = new Point(687, 213);
            dateTimeTarih.Margin = new Padding(3, 2, 3, 2);
            dateTimeTarih.Name = "dateTimeTarih";
            dateTimeTarih.Size = new Size(219, 23);
            dateTimeTarih.TabIndex = 8;
            dateTimeTarih.ValueChanged += dateTimeTarih_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(625, 248);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 9;
            label5.Text = "Fiyat";
            // 
            // buttonKaydet
            // 
            buttonKaydet.Location = new Point(696, 301);
            buttonKaydet.Margin = new Padding(3, 2, 3, 2);
            buttonKaydet.Name = "buttonKaydet";
            buttonKaydet.Size = new Size(122, 42);
            buttonKaydet.TabIndex = 11;
            buttonKaydet.Text = "Kaydet";
            buttonKaydet.UseVisualStyleBackColor = true;
            buttonKaydet.Click += buttonKaydet_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboNereden);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboNereye);
            groupBox1.Location = new Point(687, 45);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(219, 158);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "İstikamet";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(6, 21);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(613, 606);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // txtFiyat
            // 
            txtFiyat.Enabled = false;
            txtFiyat.Location = new Point(687, 245);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(219, 23);
            txtFiyat.TabIndex = 14;
            // 
            // KullaniciPaneli
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1454, 628);
            Controls.Add(txtFiyat);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(buttonKaydet);
            Controls.Add(label5);
            Controls.Add(dateTimeTarih);
            Controls.Add(label4);
            Controls.Add(comboOtobus);
            Controls.Add(label1);
            Controls.Add(listView1);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "KullaniciPaneli";
            Text = "KullaniciPaneli";
            Load += KullaniciPaneli_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Label label1;
        private ComboBox comboOtobus;
        private ComboBox comboNereden;
        private Label label2;
        private ComboBox comboNereye;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimeTarih;
        private Label label5;
        private Button buttonKaydet;
        private GroupBox groupBox1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtFiyat;
    }
}