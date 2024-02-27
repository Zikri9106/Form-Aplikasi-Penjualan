namespace AplikasiBelanja
{
    partial class FormDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBoxEditData = new PictureBox();
            pictureBoxDashboard = new PictureBox();
            pictureBoxLogOut = new PictureBox();
            label1 = new Label();
            dataGridView = new DataGridView();
            buttonPrintPDF = new Button();
            label2 = new Label();
            label3 = new Label();
            textBoxSearch = new TextBox();
            buttonsearch = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            labelJumlahPembeli = new Label();
            labelKeuntungan = new Label();
            label4 = new Label();
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
            pictureBoxEditData.TabIndex = 3;
            pictureBoxEditData.TabStop = false;
            pictureBoxEditData.Click += pictureBoxEditData_Click;
            // 
            // pictureBoxDashboard
            // 
            pictureBoxDashboard.Image = (Image)resources.GetObject("pictureBoxDashboard.Image");
            pictureBoxDashboard.Location = new Point(12, 115);
            pictureBoxDashboard.Name = "pictureBoxDashboard";
            pictureBoxDashboard.Size = new Size(182, 40);
            pictureBoxDashboard.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxDashboard.TabIndex = 2;
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
            pictureBoxLogOut.TabIndex = 1;
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
            label1.TabIndex = 0;
            label1.Text = "Selamat Datang!";
            label1.Click += label1_Click;
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = Color.White;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(222, 151);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(766, 282);
            dataGridView.TabIndex = 3;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // buttonPrintPDF
            // 
            buttonPrintPDF.Cursor = Cursors.Hand;
            buttonPrintPDF.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPrintPDF.Location = new Point(864, 447);
            buttonPrintPDF.Name = "buttonPrintPDF";
            buttonPrintPDF.Size = new Size(124, 52);
            buttonPrintPDF.TabIndex = 4;
            buttonPrintPDF.Text = "Print PDF";
            buttonPrintPDF.UseVisualStyleBackColor = true;
            buttonPrintPDF.Click += buttonPrintPDF_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(222, 96);
            label2.Name = "label2";
            label2.Size = new Size(209, 28);
            label2.TabIndex = 4;
            label2.Text = "Data Penjualan Alat Tulis";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(222, 23);
            label3.Name = "label3";
            label3.Size = new Size(236, 37);
            label3.TabIndex = 5;
            label3.Text = "Halaman Dashboard";
            // 
            // textBoxSearch
            // 
            textBoxSearch.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearch.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearch.Location = new Point(715, 98);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(185, 25);
            textBoxSearch.TabIndex = 6;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // buttonsearch
            // 
            buttonsearch.Cursor = Cursors.Hand;
            buttonsearch.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonsearch.Location = new Point(906, 98);
            buttonsearch.Name = "buttonsearch";
            buttonsearch.Size = new Size(82, 26);
            buttonsearch.TabIndex = 7;
            buttonsearch.Text = "Cari";
            buttonsearch.UseVisualStyleBackColor = true;
            buttonsearch.Click += buttonsearch_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // labelJumlahPembeli
            // 
            labelJumlahPembeli.AutoSize = true;
            labelJumlahPembeli.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelJumlahPembeli.Location = new Point(222, 447);
            labelJumlahPembeli.Name = "labelJumlahPembeli";
            labelJumlahPembeli.Size = new Size(123, 22);
            labelJumlahPembeli.TabIndex = 8;
            labelJumlahPembeli.Text = "Jumlah Pembeli     :";
            labelJumlahPembeli.Click += labelJumlahPembeli_Click;
            // 
            // labelKeuntungan
            // 
            labelKeuntungan.AutoSize = true;
            labelKeuntungan.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelKeuntungan.Location = new Point(222, 478);
            labelKeuntungan.Name = "labelKeuntungan";
            labelKeuntungan.Size = new Size(123, 22);
            labelKeuntungan.TabIndex = 9;
            labelKeuntungan.Text = "Keuntungan            :";
            labelKeuntungan.Click += labelKeuntungan_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(715, 126);
            label4.Name = "label4";
            label4.Size = new Size(155, 19);
            label4.TabIndex = 10;
            label4.Text = "* Masukkan nama pembeli";
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1000, 511);
            Controls.Add(label4);
            Controls.Add(labelKeuntungan);
            Controls.Add(labelJumlahPembeli);
            Controls.Add(buttonsearch);
            Controls.Add(textBoxSearch);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonPrintPDF);
            Controls.Add(dataGridView);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDashboard";
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
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBoxLogOut;
        private PictureBox pictureBoxEditData;
        private PictureBox pictureBoxDashboard;
        private DataGridView dataGridView;
        private Button buttonPrintPDF;
        private Label label2;
        private Label label3;
        private TextBox textBoxSearch;
        private Button buttonsearch;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Label labelJumlahPembeli;
        private Label labelKeuntungan;
        private PictureBox pictureBox2;
        private Label label4;
    }
}