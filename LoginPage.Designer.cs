namespace CSC202FinalProject
{
    partial class LoginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLogin = new Button();
            txtbxPassword = new TextBox();
            txtbxUsername = new TextBox();
            lblAdminLogin = new Label();
            label1 = new Label();
            lblPassword = new Label();
            label2 = new Label();
            chckShowPass = new CheckBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Bodoni MT Condensed", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(357, 334);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 33);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login ";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtbxPassword
            // 
            txtbxPassword.Font = new Font("Bodoni MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxPassword.Location = new Point(301, 249);
            txtbxPassword.Name = "txtbxPassword";
            txtbxPassword.Size = new Size(208, 27);
            txtbxPassword.TabIndex = 1;
            // 
            // txtbxUsername
            // 
            txtbxUsername.Font = new Font("Bodoni MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbxUsername.Location = new Point(301, 152);
            txtbxUsername.Name = "txtbxUsername";
            txtbxUsername.Size = new Size(208, 27);
            txtbxUsername.TabIndex = 2;
            // 
            // lblAdminLogin
            // 
            lblAdminLogin.AutoSize = true;
            lblAdminLogin.Font = new Font("Bodoni MT Condensed", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdminLogin.Location = new Point(301, 42);
            lblAdminLogin.Name = "lblAdminLogin";
            lblAdminLogin.Size = new Size(240, 38);
            lblAdminLogin.TabIndex = 3;
            lblAdminLogin.Text = "Administration Login";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(309, 118);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 4;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Bodoni MT Condensed", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(304, 219);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(50, 18);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bodoni MT Condensed", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(308, 118);
            label2.Name = "label2";
            label2.Size = new Size(57, 19);
            label2.TabIndex = 6;
            label2.Text = "Username:";
            // 
            // chckShowPass
            // 
            chckShowPass.AutoSize = true;
            chckShowPass.Font = new Font("Bodoni MT Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chckShowPass.Location = new Point(427, 296);
            chckShowPass.Name = "chckShowPass";
            chckShowPass.Size = new Size(91, 22);
            chckShowPass.TabIndex = 7;
            chckShowPass.Text = "Show password";
            chckShowPass.UseVisualStyleBackColor = true;
            chckShowPass.CheckedChanged += chckShowPass_CheckedChanged;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chckShowPass);
            Controls.Add(label2);
            Controls.Add(lblPassword);
            Controls.Add(label1);
            Controls.Add(lblAdminLogin);
            Controls.Add(txtbxUsername);
            Controls.Add(txtbxPassword);
            Controls.Add(btnLogin);
            Name = "LoginPage";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtbxPassword;
        private TextBox txtbxUsername;
        private Label lblAdminLogin;
        private Label label1;
        private Label lblPassword;
        private Label label2;
        private CheckBox chckShowPass;
    }
}
