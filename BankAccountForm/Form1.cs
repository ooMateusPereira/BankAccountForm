namespace BankAccountForm
{
    public partial class Form1 : Form
    {
        List<BankAccount> BankAccounts = new List<BankAccount>();
        public Form1()
        {
            InitializeComponent();

        }

        private void Owner_Click(object sender, EventArgs e)
        {

        }

        private void createAccount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox.Text))
                return;

            BankAccount bankAccount = new BankAccount(textBox.Text);
            BankAccounts.Add(bankAccount);


            RefreshGrid();
            textBox.Text = string.Empty;
        }

        private void RefreshGrid()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = BankAccounts;
        }


        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
