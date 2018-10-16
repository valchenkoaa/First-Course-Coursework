namespace Home_Bookkeeper
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TransactionsGridView = new System.Windows.Forms.DataGridView();
            this.IncomeOrExtense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ammountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AccountsTab = new System.Windows.Forms.TabControl();
            this.Wallet = new System.Windows.Forms.TabPage();
            this.AccountsGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Transactions = new System.Windows.Forms.TabPage();
            this.Categories = new System.Windows.Forms.TabPage();
            this.CategoriesGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extenseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MainMenuTool = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MakeFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveFileAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ActionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddAccountToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AnalyzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalAccountBindingSource)).BeginInit();
            this.AccountsTab.SuspendLayout();
            this.Wallet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).BeginInit();
            this.Transactions.SuspendLayout();
            this.Categories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            this.MainMenuTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // TransactionsGridView
            // 
            this.TransactionsGridView.AllowUserToAddRows = false;
            this.TransactionsGridView.AllowUserToDeleteRows = false;
            this.TransactionsGridView.AllowUserToOrderColumns = true;
            this.TransactionsGridView.AutoGenerateColumns = false;
            this.TransactionsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IncomeOrExtense,
            this.dateDataGridViewTextBoxColumn,
            this.placeDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.articleDataGridViewTextBoxColumn,
            this.ammountDataGridViewTextBoxColumn});
            this.TransactionsGridView.DataSource = this.transactionsBindingSource;
            this.TransactionsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TransactionsGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.TransactionsGridView.Location = new System.Drawing.Point(3, 3);
            this.TransactionsGridView.Name = "TransactionsGridView";
            this.TransactionsGridView.ReadOnly = true;
            this.TransactionsGridView.Size = new System.Drawing.Size(502, 512);
            this.TransactionsGridView.TabIndex = 0;
            this.TransactionsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TransactionsGridView_CellClick);
            // 
            // IncomeOrExtense
            // 
            this.IncomeOrExtense.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IncomeOrExtense.DataPropertyName = "IncomeOrExtense";
            this.IncomeOrExtense.FillWeight = 50F;
            this.IncomeOrExtense.HeaderText = "Вид";
            this.IncomeOrExtense.Name = "IncomeOrExtense";
            this.IncomeOrExtense.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.FillWeight = 65F;
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // placeDataGridViewTextBoxColumn
            // 
            this.placeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.placeDataGridViewTextBoxColumn.DataPropertyName = "Place";
            this.placeDataGridViewTextBoxColumn.FillWeight = 55F;
            this.placeDataGridViewTextBoxColumn.HeaderText = "Счёт";
            this.placeDataGridViewTextBoxColumn.Name = "placeDataGridViewTextBoxColumn";
            this.placeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.FillWeight = 80F;
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // articleDataGridViewTextBoxColumn
            // 
            this.articleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.articleDataGridViewTextBoxColumn.DataPropertyName = "Article";
            this.articleDataGridViewTextBoxColumn.FillWeight = 70F;
            this.articleDataGridViewTextBoxColumn.HeaderText = "Статья";
            this.articleDataGridViewTextBoxColumn.Name = "articleDataGridViewTextBoxColumn";
            this.articleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ammountDataGridViewTextBoxColumn
            // 
            this.ammountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ammountDataGridViewTextBoxColumn.DataPropertyName = "Money";
            this.ammountDataGridViewTextBoxColumn.FillWeight = 90F;
            this.ammountDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.ammountDataGridViewTextBoxColumn.Name = "ammountDataGridViewTextBoxColumn";
            this.ammountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transactionsBindingSource
            // 
            this.transactionsBindingSource.DataMember = "Transactions";
            this.transactionsBindingSource.DataSource = this.personalAccountBindingSource;
            // 
            // personalAccountBindingSource
            // 
            this.personalAccountBindingSource.DataSource = typeof(Home_Bookkeeper.Wallet.PersonalAccount);
            // 
            // AccountsTab
            // 
            this.AccountsTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountsTab.Controls.Add(this.Wallet);
            this.AccountsTab.Controls.Add(this.Transactions);
            this.AccountsTab.Controls.Add(this.Categories);
            this.AccountsTab.Location = new System.Drawing.Point(12, 27);
            this.AccountsTab.Name = "AccountsTab";
            this.AccountsTab.SelectedIndex = 0;
            this.AccountsTab.Size = new System.Drawing.Size(516, 544);
            this.AccountsTab.TabIndex = 1;
            // 
            // Wallet
            // 
            this.Wallet.Controls.Add(this.AccountsGridView);
            this.Wallet.Location = new System.Drawing.Point(4, 22);
            this.Wallet.Name = "Wallet";
            this.Wallet.Size = new System.Drawing.Size(508, 518);
            this.Wallet.TabIndex = 2;
            this.Wallet.Text = "Счёта";
            this.Wallet.UseVisualStyleBackColor = true;
            // 
            // AccountsGridView
            // 
            this.AccountsGridView.AllowUserToAddRows = false;
            this.AccountsGridView.AllowUserToDeleteRows = false;
            this.AccountsGridView.AllowUserToOrderColumns = true;
            this.AccountsGridView.AutoGenerateColumns = false;
            this.AccountsGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.AccountsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.AccountsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn});
            this.AccountsGridView.DataSource = this.accountsBindingSource;
            this.AccountsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccountsGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.AccountsGridView.Location = new System.Drawing.Point(0, 0);
            this.AccountsGridView.Name = "AccountsGridView";
            this.AccountsGridView.ReadOnly = true;
            this.AccountsGridView.RowTemplate.DefaultCellStyle.NullValue = "1";
            this.AccountsGridView.RowTemplate.ReadOnly = true;
            this.AccountsGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AccountsGridView.Size = new System.Drawing.Size(508, 518);
            this.AccountsGridView.TabIndex = 0;
            this.AccountsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Accounts_CellClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Имя счёта";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "Баланс";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            this.balanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accountsBindingSource
            // 
            this.accountsBindingSource.DataMember = "Accounts";
            this.accountsBindingSource.DataSource = this.personalAccountBindingSource;
            // 
            // Transactions
            // 
            this.Transactions.Controls.Add(this.TransactionsGridView);
            this.Transactions.Location = new System.Drawing.Point(4, 22);
            this.Transactions.Name = "Transactions";
            this.Transactions.Padding = new System.Windows.Forms.Padding(3);
            this.Transactions.Size = new System.Drawing.Size(508, 518);
            this.Transactions.TabIndex = 0;
            this.Transactions.Text = "Транзакции";
            this.Transactions.UseVisualStyleBackColor = true;
            // 
            // Categories
            // 
            this.Categories.Controls.Add(this.CategoriesGridView);
            this.Categories.Location = new System.Drawing.Point(4, 22);
            this.Categories.Name = "Categories";
            this.Categories.Padding = new System.Windows.Forms.Padding(3);
            this.Categories.Size = new System.Drawing.Size(508, 518);
            this.Categories.TabIndex = 1;
            this.Categories.Text = "Категории";
            this.Categories.UseVisualStyleBackColor = true;
            // 
            // CategoriesGridView
            // 
            this.CategoriesGridView.AllowUserToAddRows = false;
            this.CategoriesGridView.AllowUserToDeleteRows = false;
            this.CategoriesGridView.AllowUserToOrderColumns = true;
            this.CategoriesGridView.AutoGenerateColumns = false;
            this.CategoriesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoriesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.incomeDataGridViewTextBoxColumn,
            this.extenseDataGridViewTextBoxColumn});
            this.CategoriesGridView.DataSource = this.categoriesBindingSource;
            this.CategoriesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CategoriesGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.CategoriesGridView.Location = new System.Drawing.Point(3, 3);
            this.CategoriesGridView.Name = "CategoriesGridView";
            this.CategoriesGridView.ReadOnly = true;
            this.CategoriesGridView.Size = new System.Drawing.Size(502, 512);
            this.CategoriesGridView.TabIndex = 1;
            this.CategoriesGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoriesGridView_CellClick);
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Имя категории";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // incomeDataGridViewTextBoxColumn
            // 
            this.incomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.incomeDataGridViewTextBoxColumn.DataPropertyName = "GetIncome";
            this.incomeDataGridViewTextBoxColumn.HeaderText = "Доход по категории";
            this.incomeDataGridViewTextBoxColumn.Name = "incomeDataGridViewTextBoxColumn";
            this.incomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // extenseDataGridViewTextBoxColumn
            // 
            this.extenseDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.extenseDataGridViewTextBoxColumn.DataPropertyName = "GetExtense";
            this.extenseDataGridViewTextBoxColumn.HeaderText = "Расход по категории";
            this.extenseDataGridViewTextBoxColumn.Name = "extenseDataGridViewTextBoxColumn";
            this.extenseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.personalAccountBindingSource;
            // 
            // MainMenuTool
            // 
            this.MainMenuTool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.ActionsToolStripMenuItem,
            this.AnalyzeToolStripMenuItem,
            this.ServiceToolStripMenuItem});
            this.MainMenuTool.Location = new System.Drawing.Point(0, 0);
            this.MainMenuTool.Name = "MainMenuTool";
            this.MainMenuTool.Size = new System.Drawing.Size(540, 24);
            this.MainMenuTool.TabIndex = 2;
            this.MainMenuTool.Text = "MainMenuTool";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MakeFileToolStripMenuItem,
            this.OpenFileToolStripMenuItem,
            this.SaveFileToolStripMenuItem,
            this.SaveFileAsToolStripMenuItem,
            this.CancelToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // MakeFileToolStripMenuItem
            // 
            this.MakeFileToolStripMenuItem.Name = "MakeFileToolStripMenuItem";
            this.MakeFileToolStripMenuItem.ShortcutKeyDisplayString = "Crtl+N";
            this.MakeFileToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.MakeFileToolStripMenuItem.Text = "Создать";
            this.MakeFileToolStripMenuItem.Click += new System.EventHandler(this.MakeFileToolStripMenuItem_Click);
            // 
            // OpenFileToolStripMenuItem
            // 
            this.OpenFileToolStripMenuItem.Name = "OpenFileToolStripMenuItem";
            this.OpenFileToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+O";
            this.OpenFileToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.OpenFileToolStripMenuItem.Text = "Открыть";
            this.OpenFileToolStripMenuItem.Click += new System.EventHandler(this.OpenFileToolStripMenuItem_Click);
            // 
            // SaveFileToolStripMenuItem
            // 
            this.SaveFileToolStripMenuItem.Name = "SaveFileToolStripMenuItem";
            this.SaveFileToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+S";
            this.SaveFileToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.SaveFileToolStripMenuItem.Text = "Сохранить";
            this.SaveFileToolStripMenuItem.Click += new System.EventHandler(this.SaveFileToolStripMenuItem_Click);
            // 
            // SaveFileAsToolStripMenuItem
            // 
            this.SaveFileAsToolStripMenuItem.Name = "SaveFileAsToolStripMenuItem";
            this.SaveFileAsToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Shift+S";
            this.SaveFileAsToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.SaveFileAsToolStripMenuItem.Text = "Сохранить как...";
            this.SaveFileAsToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.SaveFileAsToolStripMenuItem.Click += new System.EventHandler(this.SaveFileAsToolStripMenuItem_Click);
            // 
            // CancelToolStripMenuItem
            // 
            this.CancelToolStripMenuItem.Name = "CancelToolStripMenuItem";
            this.CancelToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Z";
            this.CancelToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.CancelToolStripMenuItem.Text = "Отменить";
            this.CancelToolStripMenuItem.Click += new System.EventHandler(this.CancelToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.ShortcutKeyDisplayString = "Alt+F4";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // ActionsToolStripMenuItem
            // 
            this.ActionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AccountsToolStripMenuItem,
            this.CategoriesToolStripMenuItem,
            this.TransactionsToolStripMenuItem});
            this.ActionsToolStripMenuItem.Name = "ActionsToolStripMenuItem";
            this.ActionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.ActionsToolStripMenuItem.Text = "Правка";
            // 
            // AccountsToolStripMenuItem
            // 
            this.AccountsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddAccountToolStripMenuItem1,
            this.ChangeAccountToolStripMenuItem,
            this.DeleteAccountToolStripMenuItem});
            this.AccountsToolStripMenuItem.Name = "AccountsToolStripMenuItem";
            this.AccountsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.AccountsToolStripMenuItem.Text = "Работа со счетами";
            // 
            // AddAccountToolStripMenuItem1
            // 
            this.AddAccountToolStripMenuItem1.Name = "AddAccountToolStripMenuItem1";
            this.AddAccountToolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.AddAccountToolStripMenuItem1.Text = "Добавить счёт";
            this.AddAccountToolStripMenuItem1.Click += new System.EventHandler(this.AddAccountToolStripMenuItem1_Click);
            // 
            // ChangeAccountToolStripMenuItem
            // 
            this.ChangeAccountToolStripMenuItem.Name = "ChangeAccountToolStripMenuItem";
            this.ChangeAccountToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.ChangeAccountToolStripMenuItem.Text = "Изменить счёт";
            this.ChangeAccountToolStripMenuItem.Click += new System.EventHandler(this.ChangeAccountToolStripMenuItem_Click);
            // 
            // DeleteAccountToolStripMenuItem
            // 
            this.DeleteAccountToolStripMenuItem.Name = "DeleteAccountToolStripMenuItem";
            this.DeleteAccountToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.DeleteAccountToolStripMenuItem.Text = "Удалить счёт";
            this.DeleteAccountToolStripMenuItem.Click += new System.EventHandler(this.DeleteAccountToolStripMenuItem_Click);
            // 
            // CategoriesToolStripMenuItem
            // 
            this.CategoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddCategoryToolStripMenuItem,
            this.ChangeCategoryToolStripMenuItem,
            this.DeleteCategoryToolStripMenuItem});
            this.CategoriesToolStripMenuItem.Name = "CategoriesToolStripMenuItem";
            this.CategoriesToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.CategoriesToolStripMenuItem.Text = "Работа с категориями";
            // 
            // AddCategoryToolStripMenuItem
            // 
            this.AddCategoryToolStripMenuItem.Name = "AddCategoryToolStripMenuItem";
            this.AddCategoryToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.AddCategoryToolStripMenuItem.Text = "Добавить категорию";
            this.AddCategoryToolStripMenuItem.Click += new System.EventHandler(this.AddCategoryToolStripMenuItem_Click);
            // 
            // ChangeCategoryToolStripMenuItem
            // 
            this.ChangeCategoryToolStripMenuItem.Name = "ChangeCategoryToolStripMenuItem";
            this.ChangeCategoryToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.ChangeCategoryToolStripMenuItem.Text = "Изменить категорию";
            this.ChangeCategoryToolStripMenuItem.Click += new System.EventHandler(this.ChangeCategoryToolStripMenuItem_Click);
            // 
            // DeleteCategoryToolStripMenuItem
            // 
            this.DeleteCategoryToolStripMenuItem.Name = "DeleteCategoryToolStripMenuItem";
            this.DeleteCategoryToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.DeleteCategoryToolStripMenuItem.Text = "Удалить категорию";
            this.DeleteCategoryToolStripMenuItem.Click += new System.EventHandler(this.DeleteCategoryToolStripMenuItem_Click);
            // 
            // TransactionsToolStripMenuItem
            // 
            this.TransactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddTransactionToolStripMenuItem,
            this.ChangeTransactionToolStripMenuItem,
            this.DeleteTransactionToolStripMenuItem});
            this.TransactionsToolStripMenuItem.Name = "TransactionsToolStripMenuItem";
            this.TransactionsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.TransactionsToolStripMenuItem.Text = "Работа с транзакциями";
            // 
            // AddTransactionToolStripMenuItem
            // 
            this.AddTransactionToolStripMenuItem.Name = "AddTransactionToolStripMenuItem";
            this.AddTransactionToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.AddTransactionToolStripMenuItem.Text = "Добавить транзакцию";
            this.AddTransactionToolStripMenuItem.Click += new System.EventHandler(this.AddTransactionToolStripMenuItem_Click);
            // 
            // ChangeTransactionToolStripMenuItem
            // 
            this.ChangeTransactionToolStripMenuItem.Name = "ChangeTransactionToolStripMenuItem";
            this.ChangeTransactionToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.ChangeTransactionToolStripMenuItem.Text = "Изменить транзакцию";
            this.ChangeTransactionToolStripMenuItem.Click += new System.EventHandler(this.ChangeTransactionToolStripMenuItem_Click);
            // 
            // DeleteTransactionToolStripMenuItem
            // 
            this.DeleteTransactionToolStripMenuItem.Name = "DeleteTransactionToolStripMenuItem";
            this.DeleteTransactionToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.DeleteTransactionToolStripMenuItem.Text = "Удалить транзакцию";
            this.DeleteTransactionToolStripMenuItem.Click += new System.EventHandler(this.DeleteTransactionToolStripMenuItem_Click);
            // 
            // AnalyzeToolStripMenuItem
            // 
            this.AnalyzeToolStripMenuItem.Name = "AnalyzeToolStripMenuItem";
            this.AnalyzeToolStripMenuItem.ShortcutKeyDisplayString = "Alt + A";
            this.AnalyzeToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.AnalyzeToolStripMenuItem.Text = "Анализ";
            this.AnalyzeToolStripMenuItem.Click += new System.EventHandler(this.AnalyzeToolStripMenuItem_Click);
            // 
            // ServiceToolStripMenuItem
            // 
            this.ServiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.ServiceToolStripMenuItem.Name = "ServiceToolStripMenuItem";
            this.ServiceToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.ServiceToolStripMenuItem.Text = "Справка";
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.ShortcutKeyDisplayString = "Alt+H";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.HelpToolStripMenuItem.Text = "Помощь";
            this.HelpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.AboutToolStripMenuItem.Text = "О программе";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 583);
            this.Controls.Add(this.AccountsTab);
            this.Controls.Add(this.MainMenuTool);
            this.KeyPreview = true;
            this.MainMenuStrip = this.MainMenuTool;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Домашний Бухгалтер";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalAccountBindingSource)).EndInit();
            this.AccountsTab.ResumeLayout(false);
            this.Wallet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AccountsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsBindingSource)).EndInit();
            this.Transactions.ResumeLayout(false);
            this.Categories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            this.MainMenuTool.ResumeLayout(false);
            this.MainMenuTool.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MainMenuTool;
        private System.Windows.Forms.TabControl AccountsTab;
        private System.Windows.Forms.TabPage Transactions;
        private System.Windows.Forms.TabPage Categories;
        private System.Windows.Forms.TabPage Wallet;
        private System.Windows.Forms.DataGridView AccountsGridView;
        private System.Windows.Forms.DataGridView TransactionsGridView;
        private System.Windows.Forms.DataGridView CategoriesGridView;
        private System.Windows.Forms.ToolStripMenuItem ActionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddAccountToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ChangeAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CategoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AnalyzeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChangeTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MakeFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveFileAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CancelToolStripMenuItem;
        private System.Windows.Forms.BindingSource transactionsBindingSource;
        private System.Windows.Forms.BindingSource personalAccountBindingSource;
        private System.Windows.Forms.BindingSource accountsBindingSource;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extenseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IncomeOrExtense;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ammountDataGridViewTextBoxColumn;
    }
}

