namespace BankingApplication
{
    partial class Form3
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
            payButton = new Button();
            Details = new Button();
            label1 = new Label();
            label2 = new Label();
            Benificiary = new TextBox();
            amount = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // payButton
            // 
            payButton.AutoSize = true;
            payButton.Location = new Point(347, 265);
            payButton.Name = "payButton";
            payButton.Size = new Size(115, 30);
            payButton.TabIndex = 0;
            payButton.Text = "Make Payment";
            payButton.UseVisualStyleBackColor = true;
            payButton.Click += payButton_Click;
            // 
            // Details
            // 
            Details.AutoSize = true;
            Details.Location = new Point(347, 312);
            Details.Name = "Details";
            Details.Size = new Size(101, 30);
            Details.TabIndex = 1;
            Details.Text = "View Details";
            Details.UseVisualStyleBackColor = true;
            Details.Click += Details_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(305, 174);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 2;
            label1.Text = "Benificiary:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(305, 216);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 3;
            label2.Text = "Amount:";
            // 
            // Benificiary
            // 
            Benificiary.Location = new Point(405, 171);
            Benificiary.Name = "Benificiary";
            Benificiary.Size = new Size(125, 27);
            Benificiary.TabIndex = 4;
            // 
            // amount
            // 
            amount.Location = new Point(405, 213);
            amount.Name = "amount";
            amount.Size = new Size(125, 27);
            amount.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(305, 83);
            label3.Name = "label3";
            label3.Size = new Size(228, 35);
            label3.TabIndex = 6;
            label3.Text = "Make a Transaction";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(amount);
            Controls.Add(Benificiary);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Details);
            Controls.Add(payButton);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button payButton;
        private Button Details;
        private Label label1;
        private Label label2;
        private TextBox Benificiary;
        private TextBox amount;
        private Label label3;
    }
}