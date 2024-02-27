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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AplikasiBelanja
{
    public partial class FormEdit : Form
    {

        public FormEdit()
        {
            InitializeComponent();
            bind_data();
            textBoxTotalHarga.ReadOnly = true;
            dataGridView.ReadOnly = true;
            comboBoxJumlah.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxHarga.DropDownStyle = ComboBoxStyle.DropDownList;
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
            FormDashboard formDashboard = new FormDashboard();

            formDashboard.Show();

            this.Hide();
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string productName = "";

            if (radioButtonBarang1.Checked)
            {
                productName = radioButtonBarang1.Text;
            }
            else if (radioButtonBarang2.Checked)
            {
                productName = radioButtonBarang2.Text;
            }
            else if (radioButtonBarang3.Checked)
            {
                productName = radioButtonBarang3.Text;
            }
            else if (radioButtonBarang4.Checked)
            {
                productName = radioButtonBarang4.Text;
            }
            else if (radioButtonBarang5.Checked)
            {
                productName = radioButtonBarang5.Text;
            }

            if (string.IsNullOrWhiteSpace(textBoxId.Text) || string.IsNullOrWhiteSpace(textBoxNama.Text) || string.IsNullOrWhiteSpace(productName) || comboBoxJumlah.SelectedIndex == -1 || comboBoxHarga.SelectedIndex == -1)
            {
                MessageBox.Show("Mohon isi semua kolom data dan pastikan jumlah dan harga barang lebih besar dari 0.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlCommand cmd2 = new SqlCommand("INSERT INTO dataproduct(id, name, productname, productquantity, productprice, producttotal, purchasedate) VALUES (@id, @name, @productname, @productquantity, @productprice, @producttotal, @purchasedate)", conn);
            cmd2.Parameters.AddWithValue("id", textBoxId.Text);
            cmd2.Parameters.AddWithValue("name", textBoxNama.Text);
            cmd2.Parameters.AddWithValue("productname", productName);
            cmd2.Parameters.AddWithValue("productquantity", comboBoxJumlah.SelectedItem);
            cmd2.Parameters.AddWithValue("productprice", comboBoxHarga.SelectedItem);
            cmd2.Parameters.AddWithValue("producttotal", textBoxTotalHarga.Text);
            cmd2.Parameters.AddWithValue("purchasedate", monthCalendarTanggalPembelian.SelectionStart);
            conn.Open();
            cmd2.ExecuteNonQuery();
            conn.Close();
            bind_data();

            MessageBox.Show("Data telah dibuat.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBoxId.Clear();
            textBoxNama.Clear();
            radioButtonBarang1.Checked = false;
            radioButtonBarang2.Checked = false;
            radioButtonBarang3.Checked = false;
            radioButtonBarang4.Checked = false;
            radioButtonBarang5.Checked = false;
            comboBoxJumlah.SelectedIndex = -1;
            comboBoxHarga.SelectedIndex = -1;
            textBoxTotalHarga.Clear();
            monthCalendarTanggalPembelian.SelectionStart = DateTime.Today;
        }


        private void textBoxTotalHarga_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateTotalHarga()
        {
            if (int.TryParse(comboBoxJumlah.Text, out int productQuantity) && int.TryParse(comboBoxHarga.Text, out int productPrice))
            {
                int productTotal = productPrice * productQuantity;
                textBoxTotalHarga.Text = productTotal.ToString();
            }
            else
            {
                textBoxTotalHarga.Text = "";
            }
        }

        private void comboBoxJumlah_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotalHarga();
        }

        private void comboBoxHarga_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotalHarga();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView.SelectedRows[0].Index;
                string selectedNoID = dataGridView.Rows[selectedRowIndex].Cells["id"].Value.ToString();
                string productName = "";
                if (radioButtonBarang1.Checked)
                {
                    productName = radioButtonBarang1.Text;
                }
                else if (radioButtonBarang2.Checked)
                {
                    productName = radioButtonBarang2.Text;
                }
                else if (radioButtonBarang3.Checked)
                {
                    productName = radioButtonBarang3.Text;
                }
                else if (radioButtonBarang4.Checked)
                {
                    productName = radioButtonBarang4.Text;
                }
                else if (radioButtonBarang5.Checked)
                {
                    productName = radioButtonBarang5.Text;
                }

                using (SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=dataproduct;Integrated Security=True"))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand cmdUpdate = new SqlCommand("UPDATE dataproduct SET name = @name, productname = @productname, productquantity = @productquantity, productprice = @productprice, producttotal = @producttotal, purchasedate = @purchasedate WHERE id = @id", conn);
                        cmdUpdate.Parameters.AddWithValue("@id", selectedNoID);
                        cmdUpdate.Parameters.AddWithValue("@name", textBoxNama.Text);
                        cmdUpdate.Parameters.AddWithValue("@productname", productName);
                        cmdUpdate.Parameters.AddWithValue("@productquantity", comboBoxJumlah.SelectedItem);
                        cmdUpdate.Parameters.AddWithValue("@productprice", comboBoxHarga.SelectedItem);
                        cmdUpdate.Parameters.AddWithValue("@producttotal", textBoxTotalHarga.Text);
                        cmdUpdate.Parameters.AddWithValue("@purchasedate", monthCalendarTanggalPembelian.SelectionStart);
                        cmdUpdate.ExecuteNonQuery();

                        bind_data();
                        MessageBox.Show("Data berhasil diperbarui.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih baris yang akan diperbarui.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridView.SelectedRows[0].Index;
                string selectedNoID = dataGridView.Rows[selectedRowIndex].Cells["id"].Value.ToString();

                DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=dataproduct;Integrated Security=True"))
                    {
                        try
                        {
                            conn.Open();
                            SqlCommand cmdDelete = new SqlCommand("DELETE FROM dataproduct WHERE id = @id", conn);
                            cmdDelete.Parameters.AddWithValue("@id", selectedNoID);
                            cmdDelete.ExecuteNonQuery();

                            bind_data();
                            MessageBox.Show("Data berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            conn.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Pilih baris yang akan dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];
                textBoxId.Text = selectedRow.Cells["id"].Value.ToString();
                textBoxNama.Text = selectedRow.Cells["Nama"].Value.ToString();
                string productName = selectedRow.Cells["Produk"].Value.ToString();
                if (productName == radioButtonBarang1.Text)
                {
                    radioButtonBarang1.Checked = true;
                }
                else if (productName == radioButtonBarang2.Text)
                {
                    radioButtonBarang2.Checked = true;
                }
                else if (productName == radioButtonBarang3.Text)
                {
                    radioButtonBarang3.Checked = true;
                }
                else if (productName == radioButtonBarang4.Text)
                {
                    radioButtonBarang4.Checked = true;
                }
                else if (productName == radioButtonBarang5.Text)
                {
                    radioButtonBarang5.Checked = true;
                }
                comboBoxJumlah.SelectedItem = selectedRow.Cells["Jumlah"].Value.ToString();
                comboBoxHarga.SelectedItem = selectedRow.Cells["Harga"].Value.ToString();
                textBoxTotalHarga.Text = selectedRow.Cells["TotalHarga"].Value.ToString();
                monthCalendarTanggalPembelian.SelectionStart = Convert.ToDateTime(selectedRow.Cells["TanggalPembelian"].Value);
            }
        }

        private void buttonClearInput_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus semua inputan?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                textBoxId.Clear();
                textBoxNama.Clear();
                radioButtonBarang1.Checked = false;
                radioButtonBarang2.Checked = false;
                radioButtonBarang3.Checked = false;
                radioButtonBarang4.Checked = false;
                radioButtonBarang5.Checked = false;
                comboBoxJumlah.SelectedIndex = -1;
                comboBoxHarga.SelectedIndex = -1;
                textBoxTotalHarga.Clear();
                monthCalendarTanggalPembelian.SelectionStart = DateTime.Today;
            }
        }

        private void textBoxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
