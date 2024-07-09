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
    public partial class Register : Form
    {
        public Register()
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
                TextKonfirmasi.Focus();
                e.Handled = true;
            }
        }

        private void TextKonfirmasi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                PerformRegister();
            }
        }

        private void BtnKlik_Click(object sender, EventArgs e)
        {
            PerformRegister();
        }

        private void PerformRegister()
        {
            // Ambil username, password, dan konfirmasi password dari input pengguna
            string username = TextUser.Text;
            string password = TextPassword.Text;
            string confirmPassword = TextKonfirmasi.Text;

            // Lakukan validasi apakah username atau password kosong
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Username, password, dan konfirmasi password tidak boleh kosong", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lakukan validasi apakah password dan konfirmasi password sesuai
            if (password != confirmPassword)
            {
                MessageBox.Show("Password dan konfirmasi password tidak sesuai", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Buat koneksi ke database
            MySqlConnection connection = Koneksi.GetConnection();

            // Pastikan koneksi terbuka
            if (connection.State != ConnectionState.Open)
            {
                MessageBox.Show("Error: Koneksi belum dibuka.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Buat perintah SQL untuk menyimpan data pengguna baru
            string query = "INSERT INTO tb_user (username, password) VALUES (@username, @password)";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            // Eksekusi perintah SQL
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Registrasi berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Registrasi gagal", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Tutup koneksi
            if (connection.State == ConnectionState.Open)
                connection.Close();

            // Setelah berhasil diregistrasi, kembali ke form login
            FormLogin loginForm = new FormLogin();
            loginForm.Show();
            this.Hide();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            TextPassword.PasswordChar = '*';
            TextKonfirmasi.PasswordChar = '*';
        }

        private void CheckPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckPassword.Checked)
            {
                TextPassword.PasswordChar = '\0'; // Menampilkan teks biasa (tanpa karakter tersembunyi)
                TextKonfirmasi.PasswordChar = '\0'; // Menampilkan teks biasa (tanpa karakter tersembunyi)
            }
            else
            {
                TextPassword.PasswordChar = '*'; // Menggunakan karakter tersembunyi (bintang)
                TextKonfirmasi.PasswordChar = '*'; // Menggunakan karakter tersembunyi (bintang)
            }
        }
    }
}
