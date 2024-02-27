using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiBelanja
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
            bind_data();
            dataGridView.ReadOnly = true;
            labelKeuntungan_Click(null, null);
            labelJumlahPembeli_Click(null, null);
        }

        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=dataproduct;Integrated Security=True");

        private void bind_data()
        {
            SqlCommand cmd1 = new SqlCommand("SELECT id, name AS Nama, productname AS Produk, productquantity AS Jumlah, productprice AS Harga, producttotal AS TotalHarga, purchasedate AS TanggalPembelian FROM dataproduct", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);


            dataGridView.DataSource = dt;

            dataGridView.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 11);
            dataGridView.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            dataGridView.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;

            dataGridView.Columns["id"].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 11, System.Drawing.FontStyle.Bold);

            dataGridView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 11, System.Drawing.FontStyle.Bold);
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.DarkGray;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;

            dataGridView.RowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
            dataGridView.RowsDefaultCellStyle.ForeColor = System.Drawing.Color.Black;

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda ingin Log Out?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                FormLogin keLogin = new FormLogin();
                keLogin.Show();
                this.Hide();
            }
        }

        private void pictureBoxDashboard_Click(object sender, EventArgs e)
        {
        }

        private void pictureBoxEditData_Click(object sender, EventArgs e)
        {
            FormEdit formEdit = new FormEdit();

            formEdit.Show();

            this.Hide();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("SELECT id, name AS Nama, productname AS Produk, productquantity AS Jumlah, productprice AS Harga, producttotal AS TotalHarga, purchasedate AS TanggalPembelian FROM dataproduct where name Like @name+'%'", conn);
            cmd1.Parameters.AddWithValue("name", textBoxSearch.Text);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd1;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView.DataSource = dt;
            dataGridView.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 11);
            dataGridView.DefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            dataGridView.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;

            dataGridView.Columns["id"].DefaultCellStyle.Font = new System.Drawing.Font("Arial", 11, System.Drawing.FontStyle.Bold);

            dataGridView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 11, System.Drawing.FontStyle.Bold);
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.DarkGray;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;

            dataGridView.RowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
            dataGridView.RowsDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
        }

        private void buttonPrintPDF_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(0, 0, dataGridView.Width, dataGridView.Height);
            Bitmap imagebmp = new Bitmap(rect.Width, rect.Height);
            dataGridView.DrawToBitmap(imagebmp, rect);
            e.Graphics.DrawImage(imagebmp, 15, 100);
        }

        private void labelKeuntungan_Click(object sender, EventArgs e)
        {
            int totalHarga = 0;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                totalHarga += Convert.ToInt32(row.Cells["TotalHarga"].Value);
            }

            labelKeuntungan.Text = "Jumlah Keuntungan    : Rp. " + totalHarga.ToString();
        }

        private void labelJumlahPembeli_Click(object sender, EventArgs e)
        {
            int jumlahPembeli = dataGridView.Rows.Count - 1;

            labelJumlahPembeli.Text = "Jumlah Pembeli             : " + jumlahPembeli.ToString() + " Pembeli";
        }

    }
}
