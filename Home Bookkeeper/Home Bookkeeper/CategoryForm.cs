using System;
using System.Windows.Forms;

namespace Home_Bookkeeper
{
    public partial class CategoryForm : Form
    {
        private bool _isChanging;

        public CategoryForm()
        {
            InitializeComponent();
        }

        public bool Changing
        {
            get { return _isChanging; }
            set { _isChanging = value; }
        }
        public string GetCategoryNameInput => CategoryNameInput.Text;
        public string SetCategoryLable { set { CategoryName.Text = value; } }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (CategoryNameInput.Visible == true)
                if (GetCategoryNameInput == "")
                    throw new ArgumentNullException("Имя категории.", "Пустое выходное значение!");
            DialogResult = DialogResult.OK;
            Close();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            if (Changing)
            {
                categoryBindingSource.DataSource = DataBase.PersonalAccount.Categories;
                categoryBindingSource.ResetBindings(false);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void CategoryNameInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Changing)
            {
                e.Handled = true;
            }
        }
    }
}
