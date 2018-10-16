using System;
using System.Windows.Forms;

namespace Home_Bookkeeper
{
    public partial class TransactionForm : Form
    {
        private bool _isChanging;

        public TransactionForm()
        {
            InitializeComponent();
        }

        public bool Changing
        {
            get { return _isChanging; }
            set { _isChanging = value; }
        }

        public string GetAccountNameInput => AccountNameInput.Text;
        public string GetWholePartInput => WholePartInput.Text;
        public string GetDecimalPartInput => DecimalPartInput.Text;
        public string GetCategoryNameInput => CategoryNameInput.Text;
        public string GetArticleNameInput => ArticleNameInput.Text;
        public DateTime GetDateInput => Date.Value;
        public bool GetIncomeOrExtense
        {
            get { if (IncomeOrExtense.Text == "Доход") return true; else return false; }
        }

        private void WholePartInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 8) return;
            else
                e.Handled = true;
        }

        private void DecimalPartInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == 8) return;
            else
                e.Handled = true;
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (AccountNameInput.Visible == true)
                if (GetAccountNameInput == "")
                    throw new ArgumentNullException("Имя счёта.", "Пустое выходное значение!");
            if (WholePartInput.Visible == true)
                if (GetWholePartInput == "")
                    throw new ArgumentNullException("Целая часть баланса", "Пустое выходное значение!");
            if (DecimalPartInput.Visible == true)
                if (GetDecimalPartInput == "")
                    throw new ArgumentNullException("Дробная часть баланса.","Пустое выходное значение!");
            DialogResult = DialogResult.OK;
            Close();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            accountsBindingSource.DataSource = DataBase.PersonalAccount.Accounts;
            accountsBindingSource.ResetBindings(false);

            categoriesBindingSource.DataSource = DataBase.PersonalAccount.Categories;
            categoriesBindingSource.ResetBindings(false);
            
            if(Changing)
            {
                transactionsBindingSource.DataSource = DataBase.PersonalAccount.Transactions;
                transactionsBindingSource.ResetBindings(false);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void AccountNameInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void IncomeOrExtense_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void CategoryNameInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ArticleNameInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Changing)
                e.Handled = true;
        }
    }
}
