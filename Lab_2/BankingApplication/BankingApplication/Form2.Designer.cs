namespace BankingApplication
{
    partial class Form2
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
            nameLabel = new Label();
            balancelabel = new Label();
            accessLabel = new Label();
            transLabel = new Label();
            transbutton = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(280, 114);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(280, 156);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 1;
            label2.Text = "Balance:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(280, 198);
            label3.Name = "label3";
            label3.Size = new Size(124, 20);
            label3.TabIndex = 2;
            label3.Text = "Last Accessed on:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(280, 237);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 3;
            label4.Text = "Transactions:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(411, 114);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(50, 20);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "label5";
            // 
            // balancelabel
            // 
            balancelabel.AutoSize = true;
            balancelabel.Location = new Point(411, 156);
            balancelabel.Name = "balancelabel";
            balancelabel.Size = new Size(50, 20);
            balancelabel.TabIndex = 5;
            balancelabel.Text = "label6";
            // 
            // accessLabel
            // 
            accessLabel.AutoSize = true;
            accessLabel.Location = new Point(411, 198);
            accessLabel.Name = "accessLabel";
            accessLabel.Size = new Size(50, 20);
            accessLabel.TabIndex = 6;
            accessLabel.Text = "label7";
            // 
            // transLabel
            // 
            transLabel.AutoSize = true;
            transLabel.Location = new Point(411, 237);
            transLabel.Name = "transLabel";
            transLabel.Size = new Size(50, 20);
            transLabel.TabIndex = 7;
            transLabel.Text = "label8";
            // 
            // transbutton
            // 
            transbutton.AutoSize = true;
            transbutton.Location = new Point(299, 372);
            transbutton.Name = "transbutton";
            transbutton.Size = new Size(146, 45);
            transbutton.TabIndex = 8;
            transbutton.Text = "Make a Transaction";
            transbutton.UseVisualStyleBackColor = true;
            transbutton.Click += transbutton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(332, 57);
            label5.Name = "label5";
            label5.Size = new Size(90, 35);
            label5.TabIndex = 9;
            label5.Text = "Details";
            label5.Click += label5_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(transbutton);
            Controls.Add(transLabel);
            Controls.Add(accessLabel);
            Controls.Add(balancelabel);
            Controls.Add(nameLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label nameLabel;
        private Label balancelabel;
        private Label accessLabel;
        private Label transLabel;
        private Button transbutton;
        private Label label5;
    }
}