using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Login
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void TextUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                TextPassword.Focus();
                e.Handled = true;
            }
        }

        private void TextPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                PerformLogin();
            }
        }

        private void BtnKlik_Click(object sender, EventArgs e)
        {
            PerformLogin();
        }

        private void PerformLogin()
        {
            string username = TextUser.Text.Trim(); // Menghilangkan spasi di awal dan akhir
            string password = TextPassword.Text.Trim(); // Menghilangkan spasi di awal dan akhir

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username dan password tidak boleh kosong atau hanya berisi spasi", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Query SQL untuk memeriksa apakah pengguna terdaftar dengan case-sensitive username dan password
            string query = "SELECT * FROM tb_user WHERE BINARY username = @username AND BINARY password = @password";

            // Buat koneksi ke database
            MySqlConnection connection = Koneksi.GetConnection();

            // Pastikan koneksi terbuka
            if (connection.State != ConnectionState.Open)
            {
                MessageBox.Show("Error: Koneksi belum dibuka.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Buat perintah SQL
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            // Eksekusi perintah SQL
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    MessageBox.Show("Login berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Tambahkan kode untuk membuka kembali form login
                    TextUser.Text = "";
                    TextPassword.Text = "";
                }
                else
                {
                    DialogResult result = MessageBox.Show("Username atau password salah. Apakah Anda ingin register?", "Kesalahan", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (result == DialogResult.Yes)
                    {
                        // Panggil form register dan tampilkan
                        Register registerForm = new Register();
                        registerForm.Show();
                        this.Hide(); // Sembunyikan form login saat menampilkan form register
                    }
                }
            }

            // Tutup koneksi
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            TextPassword.PasswordChar = '*';
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CheckPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckPassword.Checked)
            {
                TextPassword.PasswordChar = '\0'; // Menampilkan teks biasa (tanpa karakter tersembunyi)
            }
            else
            {
                TextPassword.PasswordChar = '*'; // Menggunakan karakter tersembunyi (bintang)
            }
        }
    }
}
