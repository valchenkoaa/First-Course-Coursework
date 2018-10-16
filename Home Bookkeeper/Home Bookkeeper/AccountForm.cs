using System;
using System.Windows.Forms;

namespace Home_Bookkeeper
{
    public partial class AccountForm : Form
    {
        private bool _isChanging;

        public AccountForm()
        {
            InitializeComponent();
        }

        public bool Changing
        {
            get { return _isChanging; }
            set { _isChanging = value; }
        }
        public string GetMoney => GetWholePartInput + "," + GetDecimalPartInput;
        public string GetAccountNameInput => AccountNameInput.Text;
        public string GetWholePartInput => WholePartInput.Text;
        public string GetDecimalPartInput => DecimalPartInput.Text;
        public string SetBalanceLable { set { AccountBalance.Text = value; } }
        public string SetAccountLable { set { AccountName.Text = value; } }
        public bool VisibleBalanceInput { set { WholePartInput.Visible = value; DecimalPartInput.Visible = value; Point.Visible = value; } }
        public int SetButtonsLocation { set { Ok.Location = new System.Drawing.Point(Ok.Location.X, value); Cancel.Location = new System.Drawing.Point(Cancel.Location.X, value); } }

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
        
        private void AccountNameInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Changing)
            {
                if (WholePartInput.Visible == false && DecimalPartInput.Visible == false)
                    e.Handled = true;
            }
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
            if (Changing)
            {
                accountsBindingSource.DataSource = DataBase.PersonalAccount.Accounts;
                accountsBindingSource.ResetBindings(false);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
