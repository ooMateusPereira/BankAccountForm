namespace BankAccountForm
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
            createAccount = new Button();
            deposit = new Button();
            withdraw = new Button();
            label2 = new Label();
            numericUpDown = new NumericUpDown();
            textBox = new TextBox();
            Owner = new Label();
            dataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // createAccount
            // 
            createAccount.Location = new Point(105, 71);
            createAccount.Name = "createAccount";
            createAccount.Size = new Size(273, 42);
            createAccount.TabIndex = 0;
            createAccount.Text = "Create Account";
            createAccount.UseVisualStyleBackColor = true;
            createAccount.Click += createAccount_Click;
            // 
            // deposit
            // 
            deposit.Location = new Point(395, 258);
            deposit.Name = "deposit";
            deposit.Size = new Size(198, 42);
            deposit.TabIndex = 1;
            deposit.Text = "Deposit";
            deposit.UseVisualStyleBackColor = true;
            // 
            // withdraw
            // 
            withdraw.Location = new Point(599, 258);
            withdraw.Name = "withdraw";
            withdraw.Size = new Size(198, 42);
            withdraw.TabIndex = 2;
            withdraw.Text = "Withdraw";
            withdraw.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 272);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 5;
            label2.Text = "Amount:";
            // 
            // numericUpDown
            // 
            numericUpDown.Location = new Point(105, 270);
            numericUpDown.Name = "numericUpDown";
            numericUpDown.Size = new Size(273, 23);
            numericUpDown.TabIndex = 6;
            // 
            // textBox
            // 
            textBox.Location = new Point(105, 31);
            textBox.Name = "textBox";
            textBox.Size = new Size(273, 23);
            textBox.TabIndex = 7;
            textBox.TextChanged += textBox_TextChanged;
            // 
            // Owner
            // 
            Owner.AutoSize = true;
            Owner.Location = new Point(45, 34);
            Owner.Name = "Owner";
            Owner.Size = new Size(45, 15);
            Owner.TabIndex = 4;
            Owner.Text = "Owner:";
            Owner.Click += Owner_Click;
            // 
            // dataGridView
            // 
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(395, 31);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(402, 221);
            dataGridView.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 325);
            Controls.Add(dataGridView);
            Controls.Add(textBox);
            Controls.Add(numericUpDown);
            Controls.Add(label2);
            Controls.Add(Owner);
            Controls.Add(withdraw);
            Controls.Add(deposit);
            Controls.Add(createAccount);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createAccount;
        private Button deposit;
        private Button withdraw;
        private Label label2;
        private NumericUpDown numericUpDown;
        private Label Owner;
        private DataGridView dataGridView;
        private TextBox textBox;
    }
}
