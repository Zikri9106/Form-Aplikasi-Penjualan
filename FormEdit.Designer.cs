namespace AplikasiBelanja
{
    partial class FormEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEdit));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBoxEditData = new PictureBox();
            pictureBoxDashboard = new PictureBox();
            pictureBoxLogOut = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            dataGridView = new DataGridView();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBoxId = new TextBox();
            textBoxNama = new TextBox();
            radioButtonBarang1 = new RadioButton();
            radioButtonBarang2 = new RadioButton();
            radioButtonBarang3 = new RadioButton();
            radioButtonBarang4 = new RadioButton();
            radioButtonBarang5 = new RadioButton();
            comboBoxHarga = new ComboBox();
            comboBoxJumlah = new ComboBox();
            textBoxTotalHarga = new TextBox();
            monthCalendarTanggalPembelian = new MonthCalendar();
            buttonCreate = new Button();
            buttonClearInput = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEditData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDashboard).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogOut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBoxEditData);
            panel1.Controls.Add(pictureBoxDashboard);
            panel1.Controls.Add(pictureBoxLogOut);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 511);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(145, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // pictureBoxEditData
            // 
            pictureBoxEditData.Cursor = Cursors.Hand;
            pictureBoxEditData.Image = (Image)resources.GetObject("pictureBoxEditData.Image");
            pictureBoxEditData.Location = new Point(12, 175);
            pictureBoxEditData.Name = "pictureBoxEditData";
            pictureBoxEditData.Size = new Size(182, 40);
            pictureBoxEditData.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxEditData.TabIndex = 7;
            pictureBoxEditData.TabStop = false;
            // 
            // pictureBoxDashboard
            // 
            pictureBoxDashboard.Cursor = Cursors.Hand;
            pictureBoxDashboard.Image = (Image)resources.GetObject("pictureBoxDashboard.Image");
            pictureBoxDashboard.Location = new Point(12, 115);
            pictureBoxDashboard.Name = "pictureBoxDashboard";
            pictureBoxDashboard.Size = new Size(182, 40);
            pictureBoxDashboard.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxDashboard.TabIndex = 6;
            pictureBoxDashboard.TabStop = false;
            pictureBoxDashboard.Click += pictureBoxDashboard_Click;
            // 
            // pictureBoxLogOut
            // 
            pictureBoxLogOut.Cursor = Cursors.Hand;
            pictureBoxLogOut.Image = (Image)resources.GetObject("pictureBoxLogOut.Image");
            pictureBoxLogOut.Location = new Point(12, 460);
            pictureBoxLogOut.Name = "pictureBoxLogOut";
            pictureBoxLogOut.Size = new Size(182, 40);
            pictureBoxLogOut.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogOut.TabIndex = 5;
            pictureBoxLogOut.TabStop = false;
            pictureBoxLogOut.Click += pictureBoxLogOut_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 62);
            label1.Name = "label1";
            label1.Size = new Size(148, 28);
            label1.TabIndex = 4;
            label1.Text = "Selamat Datang!";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(222, 17);
            label3.Name = "label3";
            label3.Size = new Size(215, 37);
            label3.TabIndex = 6;
            label3.Text = "Halaman Edit Data";
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = Color.White;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(222, 349);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(766, 150);
            dataGridView.TabIndex = 8;
            dataGridView.CellClick += dataGridView_CellClick;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(222, 57);
            label2.Name = "label2";
            label2.Size = new Size(95, 22);
            label2.TabIndex = 9;
            label2.Text = "No. Pembelian";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(222, 94);
            label4.Name = "label4";
            label4.Size = new Size(96, 22);
            label4.TabIndex = 10;
            label4.Text = "Nama Pembeli";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(222, 136);
            label5.Name = "label5";
            label5.Size = new Size(92, 22);
            label5.TabIndex = 11;
            label5.Text = "Nama Barang";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(222, 221);
            label6.Name = "label6";
            label6.Size = new Size(101, 22);
            label6.TabIndex = 12;
            label6.Text = "Jumlah Barang";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(222, 270);
            label7.Name = "label7";
            label7.Size = new Size(92, 22);
            label7.TabIndex = 13;
            label7.Text = "Harga Barang";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(613, 55);
            label8.Name = "label8";
            label8.Size = new Size(78, 22);
            label8.TabIndex = 14;
            label8.Text = "Total Harga";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(613, 94);
            label9.Name = "label9";
            label9.Size = new Size(125, 22);
            label9.TabIndex = 15;
            label9.Text = "Tanggal Pembelian";
            // 
            // textBoxId
            // 
            textBoxId.BorderStyle = BorderStyle.FixedSingle;
            textBoxId.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxId.Location = new Point(339, 57);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(210, 25);
            textBoxId.TabIndex = 16;
            textBoxId.TextChanged += textBoxId_TextChanged;
            textBoxId.KeyPress += textBoxId_KeyPress;
            // 
            // textBoxNama
            // 
            textBoxNama.BorderStyle = BorderStyle.FixedSingle;
            textBoxNama.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNama.Location = new Point(339, 94);
            textBoxNama.Name = "textBoxNama";
            textBoxNama.Size = new Size(210, 25);
            textBoxNama.TabIndex = 17;
            // 
            // radioButtonBarang1
            // 
            radioButtonBarang1.AutoSize = true;
            radioButtonBarang1.Cursor = Cursors.Hand;
            radioButtonBarang1.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonBarang1.Location = new Point(339, 139);
            radioButtonBarang1.Name = "radioButtonBarang1";
            radioButtonBarang1.Size = new Size(57, 26);
            radioButtonBarang1.TabIndex = 18;
            radioButtonBarang1.TabStop = true;
            radioButtonBarang1.Text = "Buku";
            radioButtonBarang1.UseVisualStyleBackColor = true;
            // 
            // radioButtonBarang2
            // 
            radioButtonBarang2.AutoSize = true;
            radioButtonBarang2.Cursor = Cursors.Hand;
            radioButtonBarang2.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonBarang2.Location = new Point(402, 139);
            radioButtonBarang2.Name = "radioButtonBarang2";
            radioButtonBarang2.Size = new Size(69, 26);
            radioButtonBarang2.TabIndex = 19;
            radioButtonBarang2.TabStop = true;
            radioButtonBarang2.Text = "Pulpen";
            radioButtonBarang2.UseVisualStyleBackColor = true;
            // 
            // radioButtonBarang3
            // 
            radioButtonBarang3.AutoSize = true;
            radioButtonBarang3.Cursor = Cursors.Hand;
            radioButtonBarang3.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonBarang3.Location = new Point(487, 139);
            radioButtonBarang3.Name = "radioButtonBarang3";
            radioButtonBarang3.Size = new Size(62, 26);
            radioButtonBarang3.TabIndex = 20;
            radioButtonBarang3.TabStop = true;
            radioButtonBarang3.Text = "Pensil";
            radioButtonBarang3.UseVisualStyleBackColor = true;
            // 
            // radioButtonBarang4
            // 
            radioButtonBarang4.AutoSize = true;
            radioButtonBarang4.Cursor = Cursors.Hand;
            radioButtonBarang4.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonBarang4.Location = new Point(339, 171);
            radioButtonBarang4.Name = "radioButtonBarang4";
            radioButtonBarang4.Size = new Size(87, 26);
            radioButtonBarang4.TabIndex = 21;
            radioButtonBarang4.TabStop = true;
            radioButtonBarang4.Text = "Penggaris";
            radioButtonBarang4.UseVisualStyleBackColor = true;
            // 
            // radioButtonBarang5
            // 
            radioButtonBarang5.AutoSize = true;
            radioButtonBarang5.Cursor = Cursors.Hand;
            radioButtonBarang5.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonBarang5.Location = new Point(432, 171);
            radioButtonBarang5.Name = "radioButtonBarang5";
            radioButtonBarang5.Size = new Size(96, 26);
            radioButtonBarang5.TabIndex = 22;
            radioButtonBarang5.TabStop = true;
            radioButtonBarang5.Text = "Penghapus";
            radioButtonBarang5.UseVisualStyleBackColor = true;
            // 
            // comboBoxHarga
            // 
            comboBoxHarga.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxHarga.FormattingEnabled = true;
            comboBoxHarga.Items.AddRange(new object[] { "1000", "2000", "3000", "4000", "5000", "6000", "7000", "8000", "9000", "10000" });
            comboBoxHarga.Location = new Point(339, 267);
            comboBoxHarga.Name = "comboBoxHarga";
            comboBoxHarga.Size = new Size(210, 30);
            comboBoxHarga.TabIndex = 23;
            comboBoxHarga.SelectedIndexChanged += comboBoxHarga_SelectedIndexChanged;
            // 
            // comboBoxJumlah
            // 
            comboBoxJumlah.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxJumlah.FormattingEnabled = true;
            comboBoxJumlah.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            comboBoxJumlah.Location = new Point(339, 218);
            comboBoxJumlah.Name = "comboBoxJumlah";
            comboBoxJumlah.Size = new Size(210, 30);
            comboBoxJumlah.TabIndex = 24;
            comboBoxJumlah.SelectedIndexChanged += comboBoxJumlah_SelectedIndexChanged;
            // 
            // textBoxTotalHarga
            // 
            textBoxTotalHarga.BorderStyle = BorderStyle.FixedSingle;
            textBoxTotalHarga.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTotalHarga.Location = new Point(761, 55);
            textBoxTotalHarga.Name = "textBoxTotalHarga";
            textBoxTotalHarga.Size = new Size(227, 25);
            textBoxTotalHarga.TabIndex = 25;
            textBoxTotalHarga.TextChanged += textBoxTotalHarga_TextChanged;
            // 
            // monthCalendarTanggalPembelian
            // 
            monthCalendarTanggalPembelian.Location = new Point(761, 94);
            monthCalendarTanggalPembelian.Name = "monthCalendarTanggalPembelian";
            monthCalendarTanggalPembelian.TabIndex = 27;
            // 
            // buttonCreate
            // 
            buttonCreate.Cursor = Cursors.Hand;
            buttonCreate.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCreate.Location = new Point(889, 306);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(99, 31);
            buttonCreate.TabIndex = 28;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonClearInput
            // 
            buttonClearInput.Cursor = Cursors.Hand;
            buttonClearInput.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClearInput.Location = new Point(222, 312);
            buttonClearInput.Name = "buttonClearInput";
            buttonClearInput.Size = new Size(191, 31);
            buttonClearInput.TabIndex = 29;
            buttonClearInput.Text = "Clear Input";
            buttonClearInput.UseVisualStyleBackColor = true;
            buttonClearInput.Click += buttonClearInput_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Cursor = Cursors.Hand;
            buttonUpdate.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUpdate.Location = new Point(784, 306);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(99, 31);
            buttonUpdate.TabIndex = 30;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Cursor = Cursors.Hand;
            buttonDelete.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.Location = new Point(679, 306);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(99, 31);
            buttonDelete.TabIndex = 31;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // FormEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1000, 511);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonClearInput);
            Controls.Add(buttonCreate);
            Controls.Add(monthCalendarTanggalPembelian);
            Controls.Add(textBoxTotalHarga);
            Controls.Add(comboBoxJumlah);
            Controls.Add(comboBoxHarga);
            Controls.Add(radioButtonBarang5);
            Controls.Add(radioButtonBarang4);
            Controls.Add(radioButtonBarang3);
            Controls.Add(radioButtonBarang2);
            Controls.Add(radioButtonBarang1);
            Controls.Add(textBoxNama);
            Controls.Add(textBoxId);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(dataGridView);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormEdit";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEditData).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDashboard).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogOut).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBoxEditData;
        private PictureBox pictureBoxDashboard;
        private PictureBox pictureBoxLogOut;
        private Label label1;
        private Label label3;
        private DataGridView dataGridView;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBoxId;
        private TextBox textBoxNama;
        private RadioButton radioButtonBarang1;
        private RadioButton radioButtonBarang2;
        private RadioButton radioButtonBarang3;
        private RadioButton radioButtonBarang4;
        private RadioButton radioButtonBarang5;
        private ComboBox comboBoxHarga;
        private ComboBox comboBoxJumlah;
        private TextBox textBoxTotalHarga;
        private MonthCalendar monthCalendarTanggalPembelian;
        private Button buttonCreate;
        private Button buttonClearInput;
        private Button buttonUpdate;
        private Button buttonDelete;
        private PictureBox pictureBox2;
    }
}