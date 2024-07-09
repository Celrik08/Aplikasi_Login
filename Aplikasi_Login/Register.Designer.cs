namespace Aplikasi_Login
{
    partial class Register
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            CheckPassword = new CheckBox();
            TextUser = new TextBox();
            TextPassword = new TextBox();
            TextKonfirmasi = new TextBox();
            BtnKlik = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(177, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 23);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 83);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 1;
            label2.Text = "UserName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 118);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 151);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(164, 20);
            label4.TabIndex = 3;
            label4.Text = "Konfirmasi Password";
            // 
            // CheckPassword
            // 
            CheckPassword.AutoSize = true;
            CheckPassword.Location = new Point(13, 187);
            CheckPassword.Name = "CheckPassword";
            CheckPassword.Size = new Size(147, 24);
            CheckPassword.TabIndex = 4;
            CheckPassword.Text = "Show Password";
            CheckPassword.UseVisualStyleBackColor = true;
            CheckPassword.CheckedChanged += CheckPassword_CheckedChanged;
            // 
            // TextUser
            // 
            TextUser.Location = new Point(197, 75);
            TextUser.Name = "TextUser";
            TextUser.Size = new Size(195, 28);
            TextUser.TabIndex = 5;
            TextUser.KeyPress += TextUser_KeyPress;
            // 
            // TextPassword
            // 
            TextPassword.Location = new Point(197, 109);
            TextPassword.Name = "TextPassword";
            TextPassword.Size = new Size(195, 28);
            TextPassword.TabIndex = 6;
            TextPassword.KeyPress += TextPassword_KeyPress;
            // 
            // TextKonfirmasi
            // 
            TextKonfirmasi.Location = new Point(197, 143);
            TextKonfirmasi.Name = "TextKonfirmasi";
            TextKonfirmasi.Size = new Size(195, 28);
            TextKonfirmasi.TabIndex = 7;
            TextKonfirmasi.KeyPress += TextKonfirmasi_KeyPress;
            // 
            // BtnKlik
            // 
            BtnKlik.Location = new Point(373, 222);
            BtnKlik.Name = "BtnKlik";
            BtnKlik.Size = new Size(94, 29);
            BtnKlik.TabIndex = 8;
            BtnKlik.Text = "Klik";
            BtnKlik.UseVisualStyleBackColor = true;
            BtnKlik.Click += BtnKlik_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 269);
            Controls.Add(BtnKlik);
            Controls.Add(TextKonfirmasi);
            Controls.Add(TextPassword);
            Controls.Add(TextUser);
            Controls.Add(CheckPassword);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox CheckPassword;
        private TextBox TextUser;
        private TextBox TextPassword;
        private TextBox TextKonfirmasi;
        private Button BtnKlik;
    }
}