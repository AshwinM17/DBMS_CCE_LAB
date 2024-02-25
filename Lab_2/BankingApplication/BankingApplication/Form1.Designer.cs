namespace BankingApplication
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Username = new TextBox();
            Password = new TextBox();
            Submit = new Button();
            forgot = new Button();
            textBox1 = new TextBox();
            Changepass = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(288, 45);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(175, 58);
            label1.TabIndex = 0;
            label1.Text = "National Bank";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(247, 131);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(247, 204);
            label3.Name = "label3";
            label3.Size = new Size(97, 28);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // Username
            // 
            Username.Location = new Point(369, 131);
            Username.Name = "Username";
            Username.Size = new Size(125, 41);
            Username.TabIndex = 3;
            // 
            // Password
            // 
            Password.Font = new Font("Segoe UI", 15F);
            Password.Location = new Point(369, 204);
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.Size = new Size(125, 41);
            Password.TabIndex = 4;
            // 
            // Submit
            // 
            Submit.Font = new Font("Segoe UI", 9F);
            Submit.Location = new Point(250, 269);
            Submit.Name = "Submit";
            Submit.Size = new Size(94, 29);
            Submit.TabIndex = 5;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // forgot
            // 
            forgot.AutoSize = true;
            forgot.Font = new Font("Segoe UI", 9F);
            forgot.Location = new Point(366, 269);
            forgot.Name = "forgot";
            forgot.Size = new Size(128, 30);
            forgot.TabIndex = 6;
            forgot.Text = "Forgot Password";
            forgot.UseVisualStyleBackColor = true;
            forgot.Click += forgot_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9F);
            textBox1.Location = new Point(253, 322);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(241, 27);
            textBox1.TabIndex = 7;
            textBox1.Visible = false;
            // 
            // Changepass
            // 
            Changepass.AutoSize = true;
            Changepass.Font = new Font("Segoe UI", 9F);
            Changepass.Location = new Point(300, 373);
            Changepass.Name = "Changepass";
            Changepass.Size = new Size(134, 30);
            Changepass.TabIndex = 8;
            Changepass.Text = "Change Password";
            Changepass.UseVisualStyleBackColor = true;
            Changepass.Visible = false;
            Changepass.Click += Changepass_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 480);
            Controls.Add(Changepass);
            Controls.Add(textBox1);
            Controls.Add(forgot);
            Controls.Add(Submit);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5, 8, 5, 8);
            Name = "Form1";
            Text = "G";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Username;
        private TextBox Password;
        private Button Submit;
        private Button forgot;
        private TextBox textBox1;
        private Button Changepass;
    }
}
