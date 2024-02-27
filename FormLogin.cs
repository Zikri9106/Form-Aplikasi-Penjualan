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
    public partial class FormLogin : Form
    {
        public FormLogin()
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

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            FormRegister keRegister = new FormRegister();
            keRegister.Show();
            this.Hide();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda ingin keluar dari aplikasi ini?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string enteredUsername = textBoxUsername.Text;
            string enteredPassword = textBoxPassword.Text;

            try
            {
                string connectionString = "Data Source=localhost; Initial Catalog=loginapp; Integrated Security=True; TrustServerCertificate=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM loginapp WHERE username=@username AND password=@password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", enteredUsername);
                        command.Parameters.AddWithValue("@password", enteredPassword);
                        int count = (int)command.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Login berhasil!");
                            FormDashboard keDashboard = new FormDashboard();
                            keDashboard.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Username atau password salah!");
                            textBoxUsername.Clear();
                            textBoxPassword.Clear();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
