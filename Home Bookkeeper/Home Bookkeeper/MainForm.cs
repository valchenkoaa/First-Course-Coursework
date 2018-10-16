using System;
using System.Windows.Forms;

namespace Home_Bookkeeper
{
    public partial class MainForm : Form
    {
        private static string defaultFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\HomeBookkeeper";

        OpenFileDialog OPF = new OpenFileDialog
        {
            ValidateNames = true,
            Title = "Выебрите файл",
            InitialDirectory = defaultFolder,
            Filter = "Файлы .bin | *.bin"
        };

        SaveFileDialog SVF = new SaveFileDialog
        {
            ValidateNames = true,
            InitialDirectory = defaultFolder,
            Filter = "Файлы .bin | *.bin"
        };

        public MainForm()
        {
            InitializeComponent();
            ActionsToolStripMenuItem.Enabled = false;
            AnalyzeToolStripMenuItem.Enabled = false;
        }

        /// <summary>
        /// Создание файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MakeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!DataBase.IsSave)
                {
                    var result = MessageBox.Show("Сохранить файл?", "Внимание!", MessageBoxButtons.YesNoCancel);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            DataBase.SaveFile();
                            break;

                        case DialogResult.No:
                            break;

                        case DialogResult.Cancel:
                            break;
                    }
                }
                SVF.Title = "Введите имя создаваемого файла";
                if (SVF.ShowDialog() == DialogResult.OK)
                {
                    DataBase.MakeFile(SVF.FileName);
                    RefreshForm();
                }
            }
            catch (System.IO.IOException BusyFile)
            { MessageBox.Show(BusyFile.Message); }
        }

        /// <summary>
        /// Открытие файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!DataBase.IsSave)
                {
                    var result = MessageBox.Show("Сохранить файл?", "Внимание!", MessageBoxButtons.YesNoCancel);
                    switch (result)
                    {
                        case DialogResult.Yes:
                            DataBase.SaveFile();
                            break;

                        case DialogResult.No:
                            break;

                        case DialogResult.Cancel:
                            break;
                    }
                }
                if (OPF.ShowDialog() == DialogResult.OK)
                {
                    DataBase.OpenFile(OPF.FileName);
                    RefreshForm();
                }
            }
            catch (System.IO.IOException BusyFile)
            { MessageBox.Show(BusyFile.Message); }
        }

        /// <summary>
        /// Сохранение файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataBase.SaveFile();
                MessageBox.Show("Файл успешно сохранён");
                RefreshForm();
            }
            catch (System.IO.IOException BusyFile)
            { MessageBox.Show(BusyFile.Message); }
            catch (SystemException SaveFileError)
            { MessageBox.Show(SaveFileError.Message); }
        }

        /// <summary>
        /// Сохранение файла в указанное место
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveFileAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (SVF.ShowDialog() == DialogResult.OK)
                {
                    DataBase.SaveFile(SVF.FileName);
                    MessageBox.Show("Файл успешно сохранён");
                    RefreshForm();
                }
            }
            catch (System.IO.IOException BusyFile)
            { MessageBox.Show(BusyFile.Message); }
            catch (SystemException SaveFileError)
            { MessageBox.Show(SaveFileError.Message); }
        }
        
        /// <summary>
        /// Отменить последнее действия
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Action.CancelAction();
                RefreshForm();
            }
            catch (SystemException CancelError)
            { MessageBox.Show(CancelError.Message); }
        }

        /// <summary>
        /// Выход из программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!DataBase.IsSave && DataBase.PersonalAccount != null)
            {
                var result = MessageBox.Show("Сохранить файл?", "Внимание!", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.Yes:
                        DataBase.SaveFile();
                        MessageBox.Show("Файл успешно сохранён");
                        Application.Exit();
                        break;

                    case DialogResult.No:
                        Application.Exit();
                        break;

                    case DialogResult.Cancel:
                        break;
                }
            }
            else
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Добавить счёт
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddAccountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                AccountForm Input = new AccountForm();
                MessageBox.Show("Внимание! Вы не сможете изменить сумму на счёте после его создания.");
                if (Input.ShowDialog() == DialogResult.OK)
                    Action.AddAccount(Input.GetAccountNameInput, Input.GetMoney);
                RefreshForm();
            }
            catch (ArgumentNullException Exception)
            { MessageBox.Show(Exception.Message); AddAccountToolStripMenuItem1_Click(sender, e); }
            catch (DuplicateWaitObjectException DuplicateAccount)
            { MessageBox.Show(DuplicateAccount.Message); AddAccountToolStripMenuItem1_Click(sender, e); }
            catch (ArgumentException Exception)
            { MessageBox.Show(Exception.Message); AddAccountToolStripMenuItem1_Click(sender, e); }
        }

        /// <summary>
        /// Изменить счёт
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                AccountForm InputName = new AccountForm { SetBalanceLable = null, VisibleBalanceInput = false, SetButtonsLocation = 46 , Changing = true};
                if (InputName.ShowDialog() == DialogResult.OK)
                {
                    if (!DataBase.PersonalAccount.Accounts.Exists(x => x.Name == InputName.GetAccountNameInput))
                        throw new ArgumentException("Не найдено счёта с указанным именем.", InputName.GetAccountNameInput);
                    AccountForm Input = new AccountForm { SetBalanceLable = null, VisibleBalanceInput = false, SetAccountLable = "Новое имя", SetButtonsLocation = 46};
                    if (Input.ShowDialog() == DialogResult.OK)
                        Action.ChangeAccount(InputName.GetAccountNameInput, Input.GetAccountNameInput);
                    RefreshForm();
                }
            }
            catch (ArgumentNullException Exception)
            { MessageBox.Show(Exception.Message); ChangeAccountToolStripMenuItem_Click(sender, e); }
            catch (ArgumentException NotFound)
            { MessageBox.Show(NotFound.Message); ChangeAccountToolStripMenuItem_Click(sender, e); }
        }

        /// <summary>
        /// Удалить счёт
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Внимание! При удалении счёта все связанные с ним транзакции будут удалены.");
            try
            {
                AccountForm Input = new AccountForm { SetBalanceLable = null, VisibleBalanceInput = false, SetButtonsLocation = 46, Changing = true};
                if (Input.ShowDialog() == DialogResult.OK)
                    Action.DeleteAccount(Input.GetAccountNameInput);
                RefreshForm();
            }
            catch (ArgumentNullException Exception)
            { MessageBox.Show(Exception.Message); DeleteAccountToolStripMenuItem_Click(sender, e); }
            catch (ArgumentException NotFound)
            { MessageBox.Show(NotFound.Message); DeleteAccountToolStripMenuItem_Click(sender, e); }
        }

        /// <summary>
        /// Добавить категорию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CategoryForm Input = new CategoryForm();
                if (Input.ShowDialog() == DialogResult.OK)
                    Action.AddCategory(Input.GetCategoryNameInput);
                RefreshForm();
            }
            catch (ArgumentNullException Exception)
            { MessageBox.Show(Exception.Message); AddCategoryToolStripMenuItem_Click(sender, e); }
            catch (DuplicateWaitObjectException DuplicateAccount)
            { MessageBox.Show(DuplicateAccount.Message); AddCategoryToolStripMenuItem_Click(sender, e); }
            catch (ArgumentException Exception)
            { MessageBox.Show(Exception.Message); AddCategoryToolStripMenuItem_Click(sender, e); }
        }

        /// <summary>
        /// Изменить категорию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CategoryForm InputName = new CategoryForm { Changing = true };
                if (InputName.ShowDialog() == DialogResult.OK)
                {
                    if (!DataBase.PersonalAccount.Categories.Exists(x => x.Name == InputName.GetCategoryNameInput))
                        throw new ArgumentException("Не найдено категории с указанным именем.", InputName.GetCategoryNameInput);
                    CategoryForm Input = new CategoryForm { SetCategoryLable = "Новое имя" };
                    if (Input.ShowDialog() == DialogResult.OK)
                        Action.ChangeCategory(InputName.GetCategoryNameInput, Input.GetCategoryNameInput);
                    RefreshForm();
                }
            }
            catch (ArgumentNullException Exception)
            { MessageBox.Show(Exception.Message); ChangeCategoryToolStripMenuItem_Click(sender, e); }
            catch (ArgumentException NotFound)
            { MessageBox.Show(NotFound.Message); ChangeCategoryToolStripMenuItem_Click(sender, e); }
        }

        /// <summary>
        /// Удалить категорию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Внимание! При удалении категорияя все связанные с ней транзакции будут удалены.");
            try
            {
                CategoryForm Input = new CategoryForm { Changing = true };
                if (Input.ShowDialog() == DialogResult.OK)
                    Action.DeleteCategory(Input.GetCategoryNameInput);
                RefreshForm();
            }
            catch (ArgumentNullException Exception)
            { MessageBox.Show(Exception.Message); DeleteCategoryToolStripMenuItem_Click(sender, e); }
            catch (ArgumentException NotFound)
            { MessageBox.Show(NotFound.Message); DeleteCategoryToolStripMenuItem_Click(sender, e); }
            catch (ArithmeticException CantDo)
            { MessageBox.Show(CantDo.Message); DeleteCategoryToolStripMenuItem_Click(sender, e); }
        }

        /// <summary>
        /// Добавить транзакцию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TransactionForm Input = new TransactionForm();
                if (Input.ShowDialog() == DialogResult.OK)
                    Action.AddTransaction(Input.GetAccountNameInput, Input.GetCategoryNameInput, Input.GetArticleNameInput, Input.GetWholePartInput + "," + Input.GetDecimalPartInput, Input.GetDateInput, Input.GetIncomeOrExtense);
                RefreshForm();
            }
            catch (ArgumentNullException Exception)
            { MessageBox.Show(Exception.Message); AddTransactionToolStripMenuItem_Click(sender, e); }
            catch (ArgumentException NotFound)
            { MessageBox.Show(NotFound.Message); AddTransactionToolStripMenuItem_Click(sender, e); }
            catch (ArithmeticException CantDo)
            { MessageBox.Show(CantDo.Message); AddTransactionToolStripMenuItem_Click(sender, e); }
        }

        /// <summary>
        /// Изменить транзакцию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TransactionForm Input = new TransactionForm { Changing = true };
                if (Input.ShowDialog() == DialogResult.OK)
                {
                    Finances.Transaction old = new Finances.Transaction(Input.GetWholePartInput + "," + Input.GetDecimalPartInput, Input.GetCategoryNameInput, Input.GetArticleNameInput, Input.GetAccountNameInput, Input.GetDateInput, Input.GetIncomeOrExtense);
                    if (!DataBase.PersonalAccount.Transactions.Contains(old))
                        throw new ArgumentException("Транзакция не найдена.");
                    TransactionForm InputNew = new TransactionForm();
                    if (InputNew.ShowDialog() == DialogResult.OK)
                        Action.ChangeTransaction(old, InputNew.GetAccountNameInput, InputNew.GetCategoryNameInput, InputNew.GetArticleNameInput, InputNew.GetWholePartInput + "," + InputNew.GetDecimalPartInput, InputNew.GetDateInput, InputNew.GetIncomeOrExtense);
                    RefreshForm();
                }
            }
            catch (ArgumentNullException Exception)
            { MessageBox.Show(Exception.Message); ChangeTransactionToolStripMenuItem_Click(sender, e); }
            catch (ArgumentException NotFound)
            { MessageBox.Show(NotFound.Message); ChangeTransactionToolStripMenuItem_Click(sender, e); }
            catch (ArithmeticException CantDo)
            { MessageBox.Show(CantDo.Message); ChangeTransactionToolStripMenuItem_Click(sender, e); }
        }

        /// <summary>
        /// Удалить транзакцию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TransactionForm Input = new TransactionForm { Changing = true };
                if (Input.ShowDialog() == DialogResult.OK)
                {
                    Finances.Transaction old = new Finances.Transaction(Input.GetWholePartInput + "," + Input.GetDecimalPartInput, Input.GetCategoryNameInput, Input.GetArticleNameInput, Input.GetAccountNameInput, Input.GetDateInput, Input.GetIncomeOrExtense);
                    if (!DataBase.PersonalAccount.Transactions.Contains(old))
                        throw new ArgumentException("Транзакция не найдена.");
                    Action.DeleteTransaction(Input.GetAccountNameInput, Input.GetCategoryNameInput, Input.GetArticleNameInput, Input.GetWholePartInput + "," + Input.GetDecimalPartInput, Input.GetDateInput, Input.GetIncomeOrExtense);
                    RefreshForm();
                }
            }
            catch (ArgumentNullException Exception)
            { MessageBox.Show(Exception.Message); DeleteTransactionToolStripMenuItem_Click(sender, e); }
            catch (ArgumentException NotFound)
            { MessageBox.Show(NotFound.Message); DeleteTransactionToolStripMenuItem_Click(sender, e); }
            catch (ArithmeticException CantDo)
            { MessageBox.Show(CantDo.Message); DeleteTransactionToolStripMenuItem_Click(sender, e); }
        }

        /// <summary>
        /// Построение диаграммы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnalyzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Analyze CategoryDiagramm = new Analyze();
            CategoryDiagramm.ShowDialog();
        }

        /// <summary>
        /// Помощь
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch(MessageBox.Show("Желаете пройти краткое обучение работе с программой?", "Справка", MessageBoxButtons.YesNo))
            {
                case DialogResult.Yes:
                    MessageBox.Show("Счета - это то, где хранятся деньги. Баланс на счёте может быть только положительным.\n" +
                        "Например: Имя счёта - Наличные, Баланс - 5000 у.е.\n\n" +
                        "Транзакция - это любая операция прихода или расхода денег. Транзакция всегда положительная.\n" +
                        "Например: Доход - 5750 у.е. (Стипендия), Расход - 720 у.е. (Проездной на общ. транспорт).\n\n" +
                        "Категория - это раздел, к которому относятся транзакции, предназначенный для анализа.\n", "Определения");
                    MessageBox.Show("Если Вы хотите создать счёт, то подайте следующую команду:\n" +
                        "\tПравка → Добавить счёт, введите имя счёта и баланс на счету. Учтите, что баланс нельзя изменить!\n\n" +
                        "Если Вы хотите изменить счёт, то подайте следующую команду:\n" +
                        "\tПравка → Изменить счёт, выберите счёт, имя которого хотите изменить, введите новое имя счёта.\n" +
                        "Все транзакции, связанные с этим счётом, автоматически примут новое значение.\n\n" +
                        "Если Вы хотите удалить счёт, то подайте следующую команду:\n" +
                        "\tПравка → Удалить счёт, выберите счёт, который хотите удалить.\n" +
                        "Учтите, что вместе со счётом удалятся и транзакции, связанные с ним!", "Работа со счетами");
                    MessageBox.Show("Если Вы хотите создать категорию, то подайте следующую команду:\n" +
                        "\tПравка → Добавить категорию, введите имя категории.\n\n" +
                        "Если Вы хотите изменить имя категории, то подайте следующую команду:\n" +
                        "\tПравка → Изменить категорию, выберите категорию, имя которой хотите изменить, введите новое имя категории.\n" +
                        "Все транзакции, связанные с этой категорией, автоматически примут новое значение.\n\n" +
                        "Если Вы хотите удалить категорию, то подайте следующую команду:\n" +
                        "\tПравка → Удалить категорию, выберите категорию, которую хотите удалить.\n" +
                        "Учтите, что вместе с категорией удалятся и все транзакции, связанные с ней!", "Работа с категориями");
                    MessageBox.Show("Если Вы хотите создать транзакцию, то подайте следующую команду:\n" +
                        "\tПравка → Добавить транзакцию, введите требуемые данные.\n\n" +
                        "Если Вы хотите изменить транзакцию, то подайте следующую команду:\n" +
                        "\tПравка → Изменить транзакцию, введите данные транзакции, которую хотите изменить, введите новые данные.\n\n" +
                        "Если вы хотите удалить транзакцию, то подайте следующую команду:\n" +
                        "\tПравка → Удалить транзакцию, введите данные транзакции, которую хотите удалить.", "Работа с транзакциями");
                    MessageBox.Show("Создать файл \t\tCtrl + O\n" +
                        "Открыть файл \t\tCrtl + N\n" +
                        "Сохранить файл \t\tCrtl + S\n" +
                        "Сохранить файл как... \tCtrl + Shift + S\n" +
                        "Отменить \t\tCtrl + Z\n" +
                        "Анализ \t\t\tAlt + A\n" +
                        "Справка \t\tAlt + H\n" +
                        "Выход \t\t\tAlt + F4", "Горячие клавиши программы");
                    break;

                case DialogResult.No:
                    MessageBox.Show("Создать файл \t\tCtrl + O\n" +
                        "Открыть файл \t\tCrtl + N\n" +
                        "Сохранить файл \t\tCrtl + S\n" +
                        "Сохранить файл как... \tCtrl + Shift + S\n" +
                        "Отменить \t\tCtrl + Z\n" +
                        "Анализ \t\t\tAlt + A\n" +
                        "Справка \t\tAlt + H\n" +
                        "Выход \t\t\tAlt + F4", "Горячие клавиши программы");
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// Справка "О программе"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приложение \"Домашний Бухгалтер\"\n" +
                "Версия 1.0\n" +
                "© Anton Valchenko, 2018.\n" +
                "e-mail: valchenkoanton@yandex.ru", "О программе");
        }
        
        /// <summary>
        /// Действия, выполняющиеся перед закрытием главной формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!DataBase.IsSave && DataBase.PersonalAccount != null)
            {
                var result = MessageBox.Show("Сохранить файл?", "Внимание!", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.Yes:
                        DataBase.SaveFile();
                        MessageBox.Show("Файл успешно сохранён");
                        break;

                    case DialogResult.No:
                        break;

                    case DialogResult.Cancel:
                        break;
                }
            }
        }

        /// <summary>
        /// Горячие клавиши
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.N) && e.Control)
            {
                MakeFileToolStripMenuItem_Click(sender, null);
            }

            if ((e.KeyCode == Keys.O) && e.Control)
            {
                OpenFileToolStripMenuItem_Click(sender, null);
            }

            if ((e.KeyCode == Keys.S) && e.Control)
            {
                SaveFileToolStripMenuItem_Click(sender, null);
            }

            if ((e.KeyCode == Keys.S) && e.Control && e.Shift)
            {
                MakeFileToolStripMenuItem_Click(sender, null);
            }

            if ((e.KeyCode == Keys.Z) && e.Control)
            {
                CancelToolStripMenuItem_Click(sender, null);
            }

            if (AnalyzeToolStripMenuItem.Enabled == true)
                if ((e.KeyCode == Keys.A) && e.Alt)
                {
                    AnalyzeToolStripMenuItem_Click(sender, null);
                }

            if ((e.KeyCode == Keys.H) && e.Alt)
            {
                HelpToolStripMenuItem_Click(sender, null);
            }
        }

        /// <summary>
        /// Обновление формы
        /// </summary>
        private void RefreshForm()
        {
            if (DataBase.PersonalAccount != null)
            {
                UpdateDataSource();
                ActionsToolStripMenuItem.Enabled = true;
                AnalyzeToolStripMenuItem.Enabled = true;
            }
        }

        private void UpdateDataSource()
        {
            accountsBindingSource.DataSource = DataBase.PersonalAccount.Accounts;
            accountsBindingSource.ResetBindings(false);

            transactionsBindingSource.DataSource = DataBase.PersonalAccount.Transactions;
            transactionsBindingSource.ResetBindings(false);

            categoriesBindingSource.DataSource = DataBase.PersonalAccount.Categories;
            categoriesBindingSource.ResetBindings(false);
        }


        /// <summary>
        /// Событие щелчка по DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Accounts_CellClick(object sender, DataGridViewCellEventArgs e) { }

        /// <summary>
        /// Событие щелчка по DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TransactionsGridView_CellClick(object sender, DataGridViewCellEventArgs e) { }

        /// <summary>
        /// Событие щелчка по DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CategoriesGridView_CellClick(object sender, DataGridViewCellEventArgs e) { }

        private void MainForm_Load(object sender, EventArgs e)
        {
            HelpToolStripMenuItem_Click(sender, e);
        }
    }
}
