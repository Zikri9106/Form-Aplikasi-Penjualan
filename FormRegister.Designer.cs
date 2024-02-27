namespace AplikasiBelanja
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            pictureBox1 = new PictureBox();
            label6 = new Label();
            buttonShowPassword = new Button();
            label5 = new Label();
            buttonLogin = new Button();
            label4 = new Label();
            buttonRegister = new Button();
            textBoxPassword = new TextBox();
            label3 = new Label();
            buttonClose = new Button();
            label2 = new Label();
            textBoxUsername = new TextBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(475, 550);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 7F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(550, 425);
            label6.Name = "label6";
            label6.Size = new Size(258, 34);
            label6.TabIndex = 26;
            label6.Text = "Dengan registrasi ke KoperasiKu, kamu menyetujui\r\n Ketentuan dan Kebijakan Privasi kami.";
            // 
            // buttonShowPassword
            // 
            buttonShowPassword.Cursor = Cursors.Hand;
            buttonShowPassword.FlatStyle = FlatStyle.Flat;
            buttonShowPassword.Font = new Font("Poppins", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonShowPassword.Location = new Point(728, 255);
            buttonShowPassword.Name = "buttonShowPassword";
            buttonShowPassword.Size = new Size(72, 25);
            buttonShowPassword.TabIndex = 25;
            buttonShowPassword.Text = "Show";
            buttonShowPassword.UseVisualStyleBackColor = true;
            buttonShowPassword.Click += buttonShowPassword_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(625, 283);
            label5.Name = "label5";
            label5.Size = new Size(175, 22);
            label5.TabIndex = 24;
            label5.Text = "* Masukkan password anda";
            // 
            // buttonLogin
            // 
            buttonLogin.Cursor = Cursors.Hand;
            buttonLogin.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogin.Location = new Point(550, 366);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(250, 30);
            buttonLogin.TabIndex = 23;
            buttonLogin.Text = "LOGIN";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(623, 196);
            label4.Name = "label4";
            label4.Size = new Size(177, 22);
            label4.TabIndex = 22;
            label4.Text = "* Masukkan username anda";
            // 
            // buttonRegister
            // 
            buttonRegister.Cursor = Cursors.Hand;
            buttonRegister.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRegister.Location = new Point(550, 330);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(250, 30);
            buttonRegister.TabIndex = 21;
            buttonRegister.Text = "REGISTER SEKARANG";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(550, 255);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(172, 25);
            textBoxPassword.TabIndex = 20;
            textBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(550, 230);
            label3.Name = "label3";
            label3.Size = new Size(67, 22);
            label3.TabIndex = 19;
            label3.Text = "Password";
            // 
            // buttonClose
            // 
            buttonClose.Cursor = Cursors.Hand;
            buttonClose.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonClose.Location = new Point(830, 500);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(75, 30);
            buttonClose.TabIndex = 18;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(550, 145);
            label2.Name = "label2";
            label2.Size = new Size(70, 22);
            label2.TabIndex = 17;
            label2.Text = "Username";
            // 
            // textBoxUsername
            // 
            textBoxUsername.BorderStyle = BorderStyle.FixedSingle;
            textBoxUsername.Location = new Point(550, 170);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(250, 23);
            textBoxUsername.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(550, 85);
            label1.Name = "label1";
            label1.Size = new Size(109, 34);
            label1.TabIndex = 15;
            label1.Text = "Registrasi";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(550, 42);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(145, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 550);
            Controls.Add(pictureBox2);
            Controls.Add(label6);
            Controls.Add(buttonShowPassword);
            Controls.Add(label5);
            Controls.Add(buttonLogin);
            Controls.Add(label4);
            Controls.Add(buttonRegister);
            Controls.Add(textBoxPassword);
            Controls.Add(label3);
            Controls.Add(buttonClose);
            Controls.Add(label2);
            Controls.Add(textBoxUsername);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegister";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label6;
        private Button buttonShowPassword;
        private Label label5;
        private Button buttonLogin;
        private Label label4;
        private Button buttonRegister;
        private TextBox textBoxPassword;
        private Label label3;
        private Button buttonClose;
        private Label label2;
        private TextBox textBoxUsername;
        private Label label1;
        private PictureBox pictureBox2;
    }
}