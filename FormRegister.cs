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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonShowPassword_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.PasswordChar == '\0')
            {
                textBoxPassword.PasswordChar = '*';
                buttonShowPassword.Text = "Show";
            }
            else
            {
                textBoxPassword.PasswordChar = '\0';
                buttonShowPassword.Text = "Hide";
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda ingin keluar dari aplikasi ini?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxUsername.Text) && !string.IsNullOrEmpty(textBoxPassword.Text))
            {
                try
                {
                    string connectionString = "Data Source=localhost; Initial Catalog=loginapp; Integrated Security=True; TrustServerCertificate=True";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "INSERT INTO loginapp (username, password) VALUES (@username, @password)";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@username", textBoxUsername.Text);
                            command.Parameters.AddWithValue("@password", textBoxPassword.Text);
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Registrasi berhasil!");
                                textBoxUsername.Text = "";
                                textBoxPassword.Text = "";
                                FormLogin form = new FormLogin();
                                form.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Registrasi gagal!");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Username dan password harus diisi!");
            }
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            FormLogin keLogin = new FormLogin();
            keLogin.Show();
            this.Hide();
        }
    }
}
